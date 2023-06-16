using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class TabelaListagemAlugueisControl : UserControl
    {
        public TabelaListagemAlugueisControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridLinhas();

            grid.ConfigurarGridSomenteLeitura();
        }

        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "ID"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "tema",
                    HeaderText = "Tema"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "pago",
                    HeaderText = "% paga"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "valorAhPagar",
                    HeaderText = "À pagar"
                }
            };

            grid.Columns.AddRange(colunas);
        }

        public void AtualizarGrid(List<Aluguel> alugueis)
        {
            grid.Rows.Clear();

            foreach (Aluguel aluguel in alugueis)
            {
                grid.Rows.Add(aluguel.id, aluguel.tema, aluguel.porcentagemPaga, aluguel.ValorAhPagar);
            }

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {alugueis.Count} Aluguel(éis)");
        }
    }
}

