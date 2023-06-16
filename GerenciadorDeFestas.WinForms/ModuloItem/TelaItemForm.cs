using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloItem
{
    public partial class TelaItemForm : Form
    {
        private List<Item> listaItens;

        public TelaItemForm(List<Item> listaItens)
        {
            InitializeComponent();

            this.ConfigurarDialog();
            this.listaItens = listaItens;
        }

        public Item ObterItem()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = (txtNome.Text);

            string valorFormatado = txtValor.Text.Replace("R$", "");

            if (string.IsNullOrWhiteSpace(valorFormatado))
                valorFormatado = "0";

            decimal valor = Convert.ToDecimal(valorFormatado);

            Item item = new Item(nome, valor);
            item.id = id;

            return item;
        }

        public void ConfigurarValoresNaTela(Item itemSelecionado)
        {
            txtId.Text = itemSelecionado.id.ToString();
            txtNome.Text = itemSelecionado.nome;
            txtValor.Text = $"R$ {itemSelecionado.valor}";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Item item = ObterItem();

            string[] erros = item.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
                return;
            }

            foreach (Item c in listaItens)
            {
                if (item.nome == c.nome && txtId.Text == "0")
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape("O nome já está em uso.");

                    DialogResult = DialogResult.None;
                }
            }
        }
    }
}
