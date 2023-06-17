using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public partial class TelaPagamentoForm : Form
    {
        public TelaPagamentoForm()
        {
            this.ConfigurarDialog();
            InitializeComponent();
        }

        public void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            txtValorTotal.Text = $"R$ {aluguelSelecionado.valorTotal}";
            txtPorcentagem.Text = $"{aluguelSelecionado.porcentagemPaga.ToString("D")}%";
            txtValorPago.Text = $"R$ {aluguelSelecionado.valorPago}";
            txtValorPendente.Text = $"R$ {aluguelSelecionado.ValorPendente}";
        }
    }
}
