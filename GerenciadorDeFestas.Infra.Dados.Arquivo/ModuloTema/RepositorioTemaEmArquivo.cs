using GerenciadorDeFestas.Dominio.ModuloTema;

namespace GerenciadorDeFestas.Infra.Dados.Arquivo.ModuloTema
{
    public class RepositorioTemaEmArquivo : RepositorioArquivoBase<Tema>, IRepositorioTema
    {
        public RepositorioTemaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Tema> ObterRegistros()
        {
            return contextoDados.listaTemas;
        }
    }
}