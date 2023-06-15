using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.WinForms.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class TabelaListagemControl : UserControl
    {
        public TabelaListagemControl()
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

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            grid.Rows.Clear();

            foreach (Aluguel aluguel in alugueis)
            {
                grid.Rows.Add(aluguel.id, aluguel.tema, aluguel.porcentagemPaga, aluguel.ValorAhPagar);
            }

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {alugueis.Count} Aluguel(s)");
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

