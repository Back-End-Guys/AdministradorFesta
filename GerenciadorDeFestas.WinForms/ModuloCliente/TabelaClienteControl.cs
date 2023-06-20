using GerenciadorDeFestas.Dominio.ModuloCliente;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl
    {
        public TabelaClienteControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridLinhas();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            grid.Rows.Clear();

            foreach (Cliente cliente in clientes)
            {
                grid.Rows.Add(cliente.id, cliente.nome, cliente.telefone, cliente.alugueis.Count.ToString());
            }

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {clientes.Count} cliente(s)");
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
                    Name = "nome",
                    HeaderText = "Nome"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "telefone",
                    HeaderText = "Telefone"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "alugueis",
                    HeaderText = "Quantidade de aluguéis"
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
