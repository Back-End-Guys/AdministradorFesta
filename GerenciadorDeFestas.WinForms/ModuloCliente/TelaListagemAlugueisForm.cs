using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class TelaListagemAlugueisForm : Form
    {
        public TelaListagemAlugueisForm()
        {
            this.ConfigurarDialog();
            InitializeComponent();
        }

        public void SetarNome(Cliente clienteSelecionado)
        {
            lblNome.Text = clienteSelecionado.nome;
        }

        public void CarregarRegistros(List<Aluguel> alugueis)
        {
            listagem.AtualizarGrid(alugueis);
        }
    }
}
