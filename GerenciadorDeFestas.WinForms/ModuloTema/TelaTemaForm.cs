using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        public List<Tema> temas;

        public TelaTemaForm(List<Tema> temas, List<Item> itens)
        {
            InitializeComponent();

            this.ConfigurarDialog();
            ConfigurarListaItem(itens);
            this.temas = temas;
        }

        public Tema ObterTema()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nomeTema = txtNome.Text;

            Tema tema = new Tema(nomeTema);
            tema.id = id;

            tema.listaItens.AddRange(chListItens.CheckedItems.Cast<Item>());

            return tema;
        }

        public void ConfigurarTela(Tema temaSelecionado)
        {
            txtId.Text = temaSelecionado.id.ToString();
            txtNome.Text = temaSelecionado.nome;

            int i = 0;

            for (int j = 0; j < chListItens.Items.Count; j++)
            {
                Item item = (Item)chListItens.Items[j];

                if (temaSelecionado.listaItens.Contains(item))
                {
                    chListItens.SetItemChecked(i, true);
                }

                i++;
            }
        }

        public void ConfigurarListaItem(List<Item> itens)
        {
            chListItens.Items.Clear();

            chListItens.Items.AddRange(itens.ToArray());
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Tema tema = ObterTema();

            string[] erros = tema.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
                return;
            }

            foreach (Tema t in temas)
            {
                if (tema.nome == t.nome && txtId.Text == "0")
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape("Esse nome já está em uso.");

                    DialogResult = DialogResult.None;
                }
            }
        }

        private void chListItens_SelectedValueChanged(object sender, EventArgs e)
        {
            decimal valorTotal = 0;

            foreach (Item i in chListItens.CheckedItems)
            {
                valorTotal += i.valor;
            }

            txtValor.Text = $"R$ {valorTotal}";
        }
    }
}
