using GerenciadorDeFestas.Dominio.ModuloAluguel;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public partial class TelaPagamentoForm : Form
    {
        public TelaPagamentoForm()
        {
            InitializeComponent();
        }

        public void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            PorcentagemPagaEnum porcentagemPaga = aluguelSelecionado.porcentagemPaga;

            switch (porcentagemPaga)
            {
                case PorcentagemPagaEnum.Quarenta: rdbQuarenta.Checked = true;   break;

                case PorcentagemPagaEnum.Cinquenta: rdbCinquenta.Checked = true; break;

                case PorcentagemPagaEnum.Cem: rdbCem.Checked = true;             break;
            }
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
    }
}
