namespace GerenciadorDeFestas.Dominio.ModuloAluguel
{
    public interface IRepositorioAluguel : IRepositorioBase<Aluguel>
    {
        public void AtualizarPagamentoJson(int id, Aluguel aluguelSelecionado);
    }
}
