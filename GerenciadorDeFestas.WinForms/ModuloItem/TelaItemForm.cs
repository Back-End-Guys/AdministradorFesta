using GerenciadorDeFestas.Dominio.ModuloItem;
using System.Xml.Linq;

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
            decimal valor = Convert.ToDecimal(txtValor.Text);

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
    }
}
