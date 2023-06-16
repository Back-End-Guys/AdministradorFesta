using GerenciadorDeFestas.Dominio.Compartilhado;
using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloItem;

namespace GerenciadorDeFestas.Dominio.ModuloTema
{
    [Serializable]
    public class Tema : EntidadeBase<Tema>
    {

        public string nome;
        public decimal valorTotal;

        public List<Aluguel> listaAlugueis;
        public List<Item> listaItens;

        public Tema(string nome)
        {
            this.nome = nome;
            this.listaItens = new List<Item>();
            this.listaAlugueis = new List<Aluguel>();
        }

        public Tema()
        {
        }

        public override void AtualizarInformacoes(Tema registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.listaItens = registroAtualizado.listaItens;
            this.valorTotal = registroAtualizado.valorTotal;
        }

        public override string[] Validar()
        {
            List<string> erros = new();

            if (string.IsNullOrEmpty(nome))
                erros.Add("É necessário incluir um 'nome'.");

            if (listaItens.Count == 0)
                erros.Add("É necessário incluir um Item.");

            return erros.ToArray();
        }

        public decimal CalcularValor()
        {
            foreach (Item item in listaItens)
            {
                valorTotal += item.valor;
            }

            return valorTotal;
        }

        public override string ToString()
        {
            return nome;
        }
    }
}

