using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        public TelaAluguelForm(List<Cliente> clientes, List<Tema> temas)
        {
            InitializeComponent();
            this.ConfigurarDialog();

            ConfigurarComboBoxClientes(clientes);
            ConfigurarComboBoxTema(temas);
        }

        public Aluguel ObterAluguel()
        {
            int id = int.Parse(txtId.Text);
            Cliente cliente = (Cliente)cbCliente.SelectedItem;
            Tema tema = (Tema)cbTema.SelectedItem;
            DateTime data = dtData.Value;
            DateTime horaInicio = dtHorarioInicio.Value;
            DateTime horaFinal = dtHorarioFinal.Value;
            string Cep = txtCep.Text;
            string numero = txtNumero.Text;
            string nomeRua = txtRua.Text;

            Aluguel aluguel = new Aluguel(cliente, tema, data, horaInicio, horaFinal, Cep, numero, nomeRua);
            aluguel.id = id;

            if (tema != null)
                aluguel.ValorPendente = tema.valorTotal;

            return aluguel;
        }

        public void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            txtId.Text = aluguelSelecionado.id.ToString();
            cbCliente.Text = aluguelSelecionado.cliente.ToString();
            cbTema.Text = aluguelSelecionado.tema.ToString();
            dtData.Value = aluguelSelecionado.data;
            dtHorarioInicio.Value = aluguelSelecionado.horaInicio;
            dtHorarioFinal.Value = aluguelSelecionado.horaFinal;
            txtCep.Text = aluguelSelecionado.Cep;
            txtNumero.Text = aluguelSelecionado.numero;
            txtRua.Text = aluguelSelecionado.nomeRua;
            cbPorcentagens.Text = aluguelSelecionado.porcentagemPaga.ToString("D") + "%";
            txtValorTotal.Text = aluguelSelecionado.valorTotal.ToString();
            txtValorPago.Text = aluguelSelecionado.valorPago.ToString();
            txtValorPendente.Text = aluguelSelecionado.ValorPendente.ToString();
        }

        public void ConfigurarComboBoxClientes(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                cbCliente.Items.Add(cliente);
            }
        }

        public void ConfigurarComboBoxTema(List<Tema> temas)
        {
            foreach (Tema tema in temas)
            {
                cbTema.Items.Add(tema);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Aluguel aluguel = ObterAluguel();

            string[] erros = aluguel.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                if (string.IsNullOrEmpty(cbPorcentagens.Text))
                    TelaPrincipalForm.Instancia.AtualizarRodape("É necessário adicionar um sinal na 'porcentagem paga'");

                DialogResult = DialogResult.None;
                return;
            }
        }

        private void cbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            VerificarPreenchimento();
        }

        private void cbTema_SelectedValueChanged(object sender, EventArgs e)
        {
            Aluguel aluguel = ObterAluguel();

            txtValorTotal.Text = $"R$ {aluguel.tema.valorTotal}";

            VerificarPreenchimento();
        }

        private void VerificarPreenchimento()
        {
            if (string.IsNullOrEmpty(cbCliente.Text) || string.IsNullOrEmpty(cbTema.Text))
                cbPorcentagens.Enabled = false;

            else cbPorcentagens.Enabled = true;
        }

        private void cbPorcentagens_SelectedValueChanged(object sender, EventArgs e)
        {
            CalcularValores();
        }

        public void CalcularValores()
        {
            Aluguel aluguel = ObterAluguel();

            decimal porcentagemFormatada = Convert.ToDecimal(cbPorcentagens.Text.Replace("%", ""));

            decimal valorTotalFormatado = Convert.ToDecimal(txtValorTotal.Text.Replace("R$", ""));

            txtValorPago.Text = $"R$ {aluguel.CalcularValorPago(valorTotalFormatado, porcentagemFormatada)}";
            txtValorPendente.Text = $"R$ {aluguel.CalcularValorPendente(valorTotalFormatado, porcentagemFormatada)}";
        }
    }
}
