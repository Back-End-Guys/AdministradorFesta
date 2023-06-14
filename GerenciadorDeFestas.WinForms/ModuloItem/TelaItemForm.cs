using GerenciadorDeFestas.Dominio.ModuloItem;

namespace GerenciadorDeFestas.WinForms.ModuloItem
{
    public partial class TelaItemForm : Form
    {
        public TelaItemForm()
        {
            InitializeComponent();
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
            txtValor.Text = itemSelecionado.valor.ToString();
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
        }
    }
}
