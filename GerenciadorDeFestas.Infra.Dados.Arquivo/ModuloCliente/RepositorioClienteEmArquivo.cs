using GerenciadorDeFestas.Dominio.ModuloCliente;

namespace GerenciadorDeFestas.Infra.Dados.Arquivo.ModuloCliente
{
    public class RepositorioClienteEmArquivo : RepositorioArquivoBase<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Cliente> ObterRegistros()
        {
            return contextoDados.listaClientes;
        }
    }
}
