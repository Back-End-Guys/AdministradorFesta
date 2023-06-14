using GerenciadorDeFestas.Dominio.ModuloAluguel;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public partial class TelaEnderecoForm : Form
    {
        public TelaEnderecoForm()
        {
            InitializeComponent();
        }

        public void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            txtId.Text = aluguelSelecionado.id.ToString();
            txtCep.Text = aluguelSelecionado.Cep;
            txtRua.Text = aluguelSelecionado.nomeRua;
            txtNumero.Text = aluguelSelecionado.numero;
        }
    }
}
