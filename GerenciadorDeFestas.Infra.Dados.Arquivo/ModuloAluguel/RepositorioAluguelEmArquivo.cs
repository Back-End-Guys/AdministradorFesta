using GerenciadorDeFestas.Dominio.ModuloAluguel;

namespace GerenciadorDeFestas.Infra.Dados.Arquivo.ModuloAluguel
{
    public class RepositorioAluguelEmArquivo : RepositorioArquivoBase<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contextoDados.listaAluguel;
        }
        public void AtualizarPagamentoJson(int id, Aluguel aluguelSelecionado)
        {
            aluguelSelecionado.AtualizarPagamento(SelecionarPorId(id));

            contextoDados.GravarEmArquivoJson();
        }
    }
}
