using GerenciadorDeFestas.Dominio.ModuloAluguel;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public partial class TelaDescontoForm : Form
    {
        public TelaDescontoForm()
        {
            InitializeComponent();
        }

        internal void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            txtId.Text = aluguelSelecionado.id.ToString();
            txtCliente.Text = aluguelSelecionado.cliente.nome.ToString();
            txtAlugueis.Text = aluguelSelecionado.cliente.alugueis.Count.ToString() + " aluguel(éis)";
            txtDescontoPadrão.Text = "1%";
            txtDescontoPorAluguel.Text = "ainda não definido";
            txtLimite.Text = aluguelSelecionado.Limite() ? "Sim" : "Não";
            txtDescontoFinal.Text = "ainda não definido";
        }
    }
}
