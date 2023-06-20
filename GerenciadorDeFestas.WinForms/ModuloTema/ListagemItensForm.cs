using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.Dominio.ModuloTema;

namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    public partial class ListagemItensForm : Form
    {
        public ListagemItensForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public void SetNome(Tema temaSelecionado)
        {
            lblNome.Text = temaSelecionado.nome;
        }

        public void CarregarLista(List<Item> itens, decimal valorTotal)
        {
            listaItens.AtualizarListaItens(itens, valorTotal);
        }

        private void btnOK_MouseEnter(object sender, EventArgs e)
        {
            btnOK.BackColor = Color.FromArgb(255, 218, 114);
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.BackColor = SystemColors.Control;
        }
    }
}
