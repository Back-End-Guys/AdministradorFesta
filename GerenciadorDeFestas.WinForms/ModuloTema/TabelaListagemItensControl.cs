using GerenciadorDeFestas.Dominio.ModuloItem;

namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    public partial class TabelaListagemItensControl : UserControl
    {
        public TabelaListagemItensControl()
        {
            InitializeComponent();
        }

        public void AtualizarLista(List<Item> itens)
        {
            lista.Items.Clear();            

            foreach (Item item in itens)
            {
                lista.Items.Add("  → " + item);
            }
        }
    }
}
