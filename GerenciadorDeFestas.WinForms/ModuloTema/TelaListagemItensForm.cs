using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.Dominio.ModuloTema;

namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    public partial class TelaListagemItensForm : Form
    {
        public TelaListagemItensForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public void SetarNome(Tema temaSelecionado)
        {
            lblNome.Text = temaSelecionado.nome;
        }

        public void CarregarLista(List<Item> itens)
        {
            lblItens.Text = $"Esse tema possui {itens.Count} item(s) :";

            listagem.AtualizarLista(itens);
        }
    }
}
