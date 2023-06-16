﻿using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.WinForms.Compartilhado;
using GerenciadorDeFestas.WinForms.ModuloTema;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private TabelaListagemControl tabelaListagem;
        private IRepositorioCliente repositorioCliente;
        private TabelaClienteControl tabelaCliente;

        public ControladorCliente(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public override string ToolTipInserir { get { return "Inserir novo Cliente"; } }

        public override string ToolTipEditar { get { return "Editar Cliente existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Cliente existente"; } }

        public override string ToolTipListarAlugueis { get { return "Listar Alugueis do Cliente"; } }

        public override bool ListarAlugueisHabilitado => true;

        public override void Inserir()
        {
            TelaClienteForm telaCliente = new TelaClienteForm(repositorioCliente.SelecionarTodos());

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente cliente = telaCliente.ObterCliente();

                repositorioCliente.Inserir(cliente);
            }
           
            CarregarClientes();
        }

        public override void Editar()
        {
            Cliente clienteSelecionado = ObterClienteSelecionado();

            if (clienteSelecionado == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Edição de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaClienteForm telaCliente = new TelaClienteForm(repositorioCliente.SelecionarTodos());
            telaCliente.ConfigurarTela(clienteSelecionado);

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente cliente = telaCliente.ObterCliente();

                repositorioCliente.Editar(cliente.id, cliente);

            }
            
            CarregarClientes();
        }

        public override void Excluir()
        {
            Cliente cliente = ObterClienteSelecionado();

            if (cliente == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Exclusão de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o cliente {cliente.nome}?", "Exclusão de Clientes",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                if(cliente.alugueis.Count() > 0)
                {
                    MessageBox.Show("Exclusão inválida! Cliente possui aluguel(s)");
                    return;  
                }

                repositorioCliente.Excluir(cliente);
            }
            
            CarregarClientes();
        }

        public override void ListarAlugueis()
        {
            Cliente cliente = ObterClienteSelecionado();

            TelaListagemAlugueisForm telaListagemAlugueis = new TelaListagemAlugueisForm();

            if (tabelaListagem == null)
                tabelaListagem = new TabelaListagemControl();

            if (cliente == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Listagem de alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            telaListagemAlugueis.SetarNome(cliente);

            tabelaListagem.AtualizarRegistros(cliente.alugueis);

            telaListagemAlugueis.ShowDialog();
        }

        private Cliente ObterClienteSelecionado()
        {
            int id = tabelaCliente.ObterIdSelecionado();

            return repositorioCliente.SelecionarPorId(id);
        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(clientes);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

            CarregarClientes();

            return tabelaCliente;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Clientes";
        }
    }
}
