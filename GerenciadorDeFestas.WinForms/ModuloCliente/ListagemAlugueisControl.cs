using GerenciadorDeFestas.Dominio.ModuloAluguel;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class ListagemAlugueisControl : UserControl
    {
        public ListagemAlugueisControl()
        {
            InitializeComponent();
            lista.ConfigurarListView();
        }

        public void AtualizarListaAlugueis(List<Aluguel> alugueis)
        {
            lista.Items.Clear();

            lista.Columns.Add("", 0, HorizontalAlignment.Left);
            lista.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lista.Columns.Add("Tema", 300, HorizontalAlignment.Left);
            lista.Columns.Add("% paga", 200, HorizontalAlignment.Left);
            lista.Columns.Add("Valor pendente", 200, HorizontalAlignment.Left);
            lista.Columns.Add("Status", 105, HorizontalAlignment.Left);

            foreach (Aluguel aluguel in alugueis)
            {
                ListViewItem listaAluguel = new ListViewItem();
                listaAluguel.SubItems.Add(aluguel.id.ToString());
                listaAluguel.SubItems.Add(aluguel.tema.nome);
                listaAluguel.SubItems.Add(aluguel.porcentagemPaga.ToString("D") + "%");
                listaAluguel.SubItems.Add(aluguel.valorPendente.ToString("C"));
                listaAluguel.SubItems.Add(aluguel.status);
                
                listaAluguel.BackColor = Color.FromArgb(255, 230, 143);

                lista.Items.Add(listaAluguel);
            }
        }
    }
}

