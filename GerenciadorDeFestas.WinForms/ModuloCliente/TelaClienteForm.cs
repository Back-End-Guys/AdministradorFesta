using GerenciadorDeFestas.Dominio.ModuloCliente;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente;
        List<Cliente> clientes;

        public TelaClienteForm(List<Cliente> clientes)
        {
            InitializeComponent();

            this.ConfigurarDialog();
            this.clientes = clientes;
        }

        public Cliente ObterCliente()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;

            cliente = new Cliente(nome, telefone);
            cliente.id = id;

            return cliente;
        }

        public void ConfigurarTela(Cliente clienteSelecionado)
        {
            txtId.Text = clienteSelecionado.id.ToString();
            txtNome.Text = clienteSelecionado.nome;
            txtTelefone.Text = clienteSelecionado.telefone;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Cliente cliente = ObterCliente();

            string[] erros = cliente.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
                return;
            }

            foreach (Cliente c in clientes)
            {
                if (cliente.nome == c.nome && txtId.Text == "0")
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape("O nome já está em uso.");

                    DialogResult = DialogResult.None;
                }
            }
        }

        private void TelaClienteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
