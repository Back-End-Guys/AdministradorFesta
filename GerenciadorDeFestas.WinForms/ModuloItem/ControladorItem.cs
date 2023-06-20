using GerenciadorDeFestas.Dominio.ModuloItem;

namespace GerenciadorDeFestas.WinForms.ModuloItem
{
    public class ControladorItem : ControladorBase
    {
        IRepositorioItem repositorioItem;
        TabelaItemControl tabelaItem;

        public ControladorItem(IRepositorioItem repositorioItem)
        {
            this.repositorioItem = repositorioItem;
        }

        public override string ToolTipInserir => "Inserir novo item";

        public override string ToolTipEditar => "Editar item";

        public override string ToolTipExcluir => "Excluir item";

        public override void Inserir()
        {
            TelaItemForm telaItem = new TelaItemForm(repositorioItem.SelecionarTodos());
            telaItem.Text = "Cadastrar novo item";

            DialogResult opcaoEscolhida = telaItem.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Item novoItem = telaItem.ObterItem();

                repositorioItem.Inserir(novoItem);
            }

            CarregarItens();
        }

        public override void Editar()
        {
            Item itemSelecionado = ObterItemSelecionado();

            if (itemSelecionado == null)
            {
                MessageBox.Show("Selecione um item primeiro", "Edição de Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            TelaItemForm telaItem = new TelaItemForm(repositorioItem.SelecionarTodos());
            telaItem.Text = "Editar item existente";

            telaItem.ConfigurarValoresNaTela(itemSelecionado);

            DialogResult opcaoEscolhida = telaItem.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Item item = telaItem.ObterItem();

                repositorioItem.Editar(item.id, item);
            }

            CarregarItens();
        }

        public override void Excluir()
        {
            Item itemSelecionado = ObterItemSelecionado();

            if (itemSelecionado == null)
            {
                MessageBox.Show("Selecione um item primeiro", "Excluir item exitente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o item \"{itemSelecionado.nome}\"?",
             "Excluir item existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                if (itemSelecionado.listaTemas.Count() > 0)
                {
                    MessageBox.Show("Exclusão inválida! Item está em um tema(s)", "Excluir item existente",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                repositorioItem.Excluir(itemSelecionado);
            }

            CarregarItens();
        }

        private void CarregarItens()
        {
            List<Item> itens = repositorioItem.SelecionarTodos();

            tabelaItem.AtualizarRegistros(itens);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaItem == null)
                tabelaItem = new TabelaItemControl();

            CarregarItens();

            return tabelaItem;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Itens";
        }

        private Item ObterItemSelecionado()
        {
            int id = tabelaItem.ObterIdSelecionado();

            return repositorioItem.SelecionarPorId(id);
        }
    }
}
