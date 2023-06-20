using GerenciadorDeFestas.Dominio.ModuloAluguel;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridLinhas();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            grid.Rows.Clear();

            foreach (Aluguel aluguel in alugueis)
            {
                grid.Rows.Add(aluguel.id, aluguel.cliente, aluguel.tema, 
                    aluguel.data.ToString("dd/MM/yyyy"), 
                    aluguel.horaInicio.ToString("HH:mm"), 
                    aluguel.horaFinal.ToString("HH:mm"), 
                    aluguel.dataFechamento == new DateTime() ? " -" : aluguel.dataFechamento.ToString("dd/MM/yyyy"), 
                    aluguel.status,
                    aluguel.porcentagemPaga.ToString("D") + "%",
                    aluguel.valorPendente.ToString("C"),
                    aluguel.valorTotal.ToString("C"));
            }

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {alugueis.Count} aluguel(éis)");
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
                    Name = "cliente",
                    HeaderText = "Cliente"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "tema",
                    HeaderText = "Tema"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "horarioInicial",
                    HeaderText = "Início"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "horarioFinal",
                    HeaderText = "Fim"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "dataFechamento",
                    HeaderText = "Fechamento"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "status",
                    HeaderText = "Status"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "porcentagem",
                    HeaderText = "% Paga"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "valorPendente",
                    HeaderText = "Valor Pendente"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "valorTotal",
                    HeaderText = "Valor Total"
                },
            };

            grid.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
