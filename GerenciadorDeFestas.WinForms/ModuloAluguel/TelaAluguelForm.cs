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
            Cliente cliente = (Cliente)txtCliente.SelectedItem;
            Tema tema = (Tema)txtTema.SelectedItem;
            DateTime data = txtData.Value;
            DateTime horaInicio = txtHorarioInicio.Value;
            DateTime horaFinal = txtHorarioFinal.Value;
            string Cep = txtCep.Text;
            string numero = txtNumero.Text;
            string nomeRua = txtRua.Text;

            Aluguel aluguel = new Aluguel(cliente, tema, data, horaInicio, horaFinal, Cep, numero, nomeRua);

            aluguel.id = id;

            return aluguel;
        }

        public void ConfigurarValoresNaTela(Aluguel aluguelSelecionado)
        {
            txtId.Text = aluguelSelecionado.id.ToString();
            txtCliente.Text = aluguelSelecionado.cliente.ToString();
            txtTema.Text = aluguelSelecionado.tema.ToString();
            txtData.Value = aluguelSelecionado.data;
            txtHorarioInicio.Value = aluguelSelecionado.horaInicio;
            txtHorarioFinal.Value = aluguelSelecionado.horaFinal;
            txtCep.Text = aluguelSelecionado.Cep;
            txtNumero.Text = aluguelSelecionado.numero;
            txtRua.Text = aluguelSelecionado.nomeRua;
        }

        public void ConfigurarComboBoxClientes(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes) 
            { 
                txtCliente.Items.Add(cliente);
            }
        }

        public void ConfigurarComboBoxTema(List<Tema> temas)
        {
            foreach (Tema tema in temas)
            {
                txtTema.Items.Add(tema);
            }
        }


    }
}
