using GerenciadorDeFestas.Dominio.Compartilhado;
using GerenciadorDeFestas.Dominio.ModuloItem;

namespace GerenciadorDeFestas.Dominio.ModuloTema
{
    [Serializable]
    public class Tema : EntidadeBase<Tema>
    {

        public string nome;
        public decimal valorTotal;

        public List<Item> listaItens;

        public Tema(string nome)
        {
            this.nome = nome;
            this.listaItens = new List<Item>();
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

    }
}

