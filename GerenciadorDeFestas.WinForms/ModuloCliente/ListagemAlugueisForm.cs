using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class ListagemAlugueisForm : Form
    {
        public ListagemAlugueisForm()
        {
            this.ConfigurarDialog();
            InitializeComponent();
        }

        public void SetarNome(Cliente clienteSelecionado)
        {
            lblNome.Text = clienteSelecionado.nome;
        }

        public void CarregarRegistros(List<Aluguel> alugueis)
        {
            listaAlugueis.AtualizarListaAlugueis(alugueis);
        }

        private void btnOK_MouseEnter(object sender, EventArgs e)
        {
            btnOK.BackColor = Color.FromArgb(255, 218, 114);
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.BackColor = SystemColors.Control;
        }
    }
}
