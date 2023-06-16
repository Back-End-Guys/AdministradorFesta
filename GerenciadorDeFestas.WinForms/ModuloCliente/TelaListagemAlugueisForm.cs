
using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class TelaListagemAlugueisForm : Form
    {
        public TelaListagemAlugueisForm()
        {
            InitializeComponent();
        }

        public void SetarNome(Cliente clienteSelecionado)
        {
            lblNome.Text = clienteSelecionado.nome;
        }
    }
}
