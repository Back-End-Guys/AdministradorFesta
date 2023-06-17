using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.WinForms.Compartilhado;

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

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguelSelecionado = telaAluguel.ObterAluguel();

                aluguelSelecionado.cliente.alugueis.Add(aluguelSelecionado);
                aluguelSelecionado.tema.listaAlugueis.Add(aluguelSelecionado);

                decimal porcentagemPaga = Convert.ToDecimal(aluguelSelecionado.porcentagemPaga);

                aluguelSelecionado.ValorPendente = aluguelSelecionado.CalcularValorPendente(aluguelSelecionado.ValorPendente, porcentagemPaga);
                aluguelSelecionado.valorPago = aluguelSelecionado.CalcularValorPago(aluguelSelecionado.ValorPendente, porcentagemPaga);

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

            TelaAluguelForm telaAluguel = new TelaAluguelForm(repositorioCliente.SelecionarTodos(), repositorioTema.SelecionarTodos());
            telaAluguel.ConfigurarTela(aluguelSelecionado);

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = telaAluguel.ObterAluguel();

                repositorioAluguel.Editar(aluguel.id, aluguel);
            }

            CarregarAlugueis();
        }

        public override void Excluir()
        {
            Aluguel aluguel = ObterAluguelSelecionado();

            if (aluguel == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                    "Exclusão de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o aluguel \"{aluguel.tema}\"?", "Exclusão de Alugueis",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                for(int i = 0; i < aluguel.cliente.alugueis.Count(); i++)
                {
                    if (aluguel.cliente.alugueis[i] == aluguel)
                    {
                        aluguel.cliente.alugueis.Remove(aluguel.cliente.alugueis[i]);
                    }
                }

                for (int i = 0; i < aluguel.tema.listaAlugueis.Count(); i++)
                {
                    if (aluguel.tema.listaAlugueis[i] == aluguel)
                    {
                        aluguel.tema.listaAlugueis.Remove(aluguel.tema.listaAlugueis[i]);    
                    }
                }

                repositorioAluguel.Excluir(aluguel);
            }

            CarregarAlugueis();
        }

        public override void Pagamento()
        {
            TelaPagamentoForm telaPagamento = new TelaPagamentoForm();

            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            telaPagamento.ConfigurarTela(aluguelSelecionado);

            DialogResult opcaoEscolhida = telaPagamento.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioAluguel.AtualizarPagamentoJson(aluguelSelecionado.id, aluguelSelecionado);

                aluguelSelecionado.FinalizarPagamento();
            }

            CarregarAlugueis();
        }

        public override void Endereco()
        {
            TelaEnderecoForm telaEndereco = new TelaEnderecoForm();

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
