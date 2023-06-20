using GerenciadorDeFestas.Dominio.ModuloItem;

namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    public partial class ListagemItensControl : UserControl
    {
        public ListagemItensControl()
        {
            InitializeComponent();
            lista.ConfigurarListView();
        }

        public void AtualizarListaItens(List<Item> itens, decimal valorTotal)
        {
            lista.Items.Clear(); 

            lista.Columns.Add("", 0, HorizontalAlignment.Left);
            lista.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lista.Columns.Add("Itens", 500, HorizontalAlignment.Left);
            lista.Columns.Add("Valor", 246, HorizontalAlignment.Left);

            foreach (Item item in itens)
            {
                ListViewItem listaItem = new ListViewItem();
                listaItem.SubItems.Add(item.id.ToString());
                listaItem.SubItems.Add(item.nome);
                listaItem.SubItems.Add(item.valor.ToString("C"));

                listaItem.BackColor = Color.FromArgb(255, 230, 143);

                lista.Items.Add(listaItem);
            }

            ListViewItem totalItem = new ListViewItem("");
            totalItem.BackColor = Color.FromArgb(246, 209, 85);
            totalItem.SubItems.Add("");
            totalItem.SubItems.Add("Valor total: ");
            totalItem.SubItems.Add(valorTotal.ToString("C"));

            lista.Items.Add(totalItem);
        }
    }
}
