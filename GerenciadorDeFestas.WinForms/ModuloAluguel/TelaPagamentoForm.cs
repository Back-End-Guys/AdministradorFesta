using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;
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
        public PorcentagemPagaEnum PorcentagemPaga(Aluguel aluguelSelecionado)
        {
            if (rdbQuarenta.Checked)
                return aluguelSelecionado.porcentagemPaga = PorcentagemPagaEnum.Quarenta;

            else if (rdbCinquenta.Checked)
                return aluguelSelecionado.porcentagemPaga = PorcentagemPagaEnum.Cinquenta;

            else if (rdbCem.Checked)
                return aluguelSelecionado.porcentagemPaga = PorcentagemPagaEnum.Cem;

            return aluguelSelecionado.porcentagemPaga = 0;
        }
        public void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            if (aluguelSelecionado.porcentagemPaga == PorcentagemPagaEnum.Quarenta)
                rdbQuarenta.Checked = true;

            else if (aluguelSelecionado.porcentagemPaga == PorcentagemPagaEnum.Cinquenta)
                rdbCinquenta.Checked = true;

            else if (aluguelSelecionado.porcentagemPaga == PorcentagemPagaEnum.Cem)
                rdbCem.Checked = true;
        }
    }
}
