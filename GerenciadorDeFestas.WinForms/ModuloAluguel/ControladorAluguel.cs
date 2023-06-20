using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloTema;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{

    public class ControladorAluguel : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;
        private IRepositorioTema repositorioTema;
        private IRepositorioAluguel repositorioAluguel;

        private TabelaAluguelControl tabelaAluguel;

        public ControladorAluguel(IRepositorioAluguel repositorioAluguel, IRepositorioCliente repositorioCliente, IRepositorioTema repositorioTema)
        {
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
        }

        public override string ToolTipInserir => "Inserir novo Aluguel";

        public override string ToolTipEditar => "Editar Aluguel existente";

        public override string ToolTipExcluir => "Excluir Aluguel existente";

        public override string ToolTipPagamento => "Pagamento Aluguel";

        public override string ToolTipEndereco => "Endereço Aluguel";

        public override bool PagamentoHabilitado => true;

        public override bool EnderecoHabilitado => true;

        public override void Inserir()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm(repositorioCliente.SelecionarTodos(), repositorioTema.SelecionarTodos());
            telaAluguel.Text = "Cadastrar novo aluguel";

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguelSelecionado = telaAluguel.ObterAluguel();

                aluguelSelecionado.CalcularValorTotal();
                aluguelSelecionado.CalcularValorPendente();

                aluguelSelecionado.cliente.alugueis.Add(aluguelSelecionado);

                repositorioAluguel.Inserir(aluguelSelecionado);
            }

            CarregarAlugueis();
        }

        public override void Editar()
        {
            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                    "Edição de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            if (aluguelSelecionado.status == "Fechado")
            {
                MessageBox.Show($"Não é possível editar um aluguel já concluído!",
                    "Edição de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaAluguelForm telaAluguel = new TelaAluguelForm(repositorioCliente.SelecionarTodos(), repositorioTema.SelecionarTodos());
            telaAluguel.Text = "Editar aluguel existente";
            telaAluguel.ConfigurarTela(aluguelSelecionado);

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = telaAluguel.ObterAluguel();

                aluguel.CalcularValorTotal();
                aluguel.CalcularValorPendente();

                repositorioAluguel.Editar(aluguel.id, aluguel);
            }

            CarregarAlugueis();
        }

        public override void Excluir()
        {
            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                    "Excluir aluguel existente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            if (aluguelSelecionado.status == "Aberto")
            {
                MessageBox.Show($"Não é possível excluir um aluguel ainda não concluído!",
                    "Edição de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o aluguel \"{aluguelSelecionado.tema.nome}\" do cliente \"{aluguelSelecionado.cliente.nome}\"?", "Excluir aluguel existente",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.Yes)
            {
                for (int i = 0; i < aluguelSelecionado.cliente.alugueis.Count(); i++)
                {
                    if (aluguelSelecionado.cliente.alugueis[i] == aluguelSelecionado)
                    {
                        aluguelSelecionado.cliente.alugueis.Remove(aluguelSelecionado.cliente.alugueis[i]);
                    }
                }

                for (int i = 0; i < aluguelSelecionado.tema.listaAlugueis.Count(); i++)
                {
                    if (aluguelSelecionado.tema.listaAlugueis[i] == aluguelSelecionado)
                    {
                        aluguelSelecionado.tema.listaAlugueis.Remove(aluguelSelecionado.tema.listaAlugueis[i]);
                    }
                }

                repositorioAluguel.Excluir(aluguelSelecionado);
            }

            CarregarAlugueis();
        }

        public override void Pagamento()
        {
            TelaPagamentoForm telaPagamento = new TelaPagamentoForm();
            telaPagamento.Text = "Definir porcentagem paga";

            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                    "Edição de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            if (aluguelSelecionado.status == "Fechado")
            {
                MessageBox.Show($"Não é possível editar a porcentagem paga de um aluguel já concluído!",
                    "Edição de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            telaPagamento.ConfigurarTela(aluguelSelecionado);

            DialogResult opcaoEscolhida = telaPagamento.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                telaPagamento.PorcentagemPaga(aluguelSelecionado);

                aluguelSelecionado.valorPendente = aluguelSelecionado.CalcularValorPendente();

                repositorioAluguel.AtualizarPagamentoJson(aluguelSelecionado.id, aluguelSelecionado);

                aluguelSelecionado.FinalizarPagamento();
            }

            CarregarAlugueis();
        }

        public override void Endereco()
        {
            TelaEnderecoForm telaEndereco = new TelaEnderecoForm();
            telaEndereco.Text = "Exibir informações de localização";

            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            telaEndereco.ConfigurarTela(aluguelSelecionado);

            telaEndereco.ShowDialog();
        }

        private Aluguel ObterAluguelSelecionado()
        {
            int id = tabelaAluguel.ObterIdSelecionado();

            return repositorioAluguel.SelecionarPorId(id);
        }

        private void CarregarAlugueis()
        {
            List<Aluguel> listaAlugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(listaAlugueis);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarAlugueis();

            return tabelaAluguel;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Aluguéis";
        }
    }
}
