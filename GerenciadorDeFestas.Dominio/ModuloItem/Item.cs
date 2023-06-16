using GerenciadorDeFestas.Dominio.Compartilhado;
using GerenciadorDeFestas.Dominio.ModuloTema;

namespace GerenciadorDeFestas.Dominio.ModuloItem
{
    [Serializable]
    public class Item : EntidadeBase<Item>
    {
        public string nome;
        public decimal valor;

        public List<Tema> listaTemas;

        public Item(string nome, decimal valor)
        {
            this.nome = nome;
            this.valor = valor;
            listaTemas = new List<Tema>();
        }

        public Item()
        {
        }

        public override void AtualizarInformacoes(Item registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.valor = registroAtualizado.valor;
        }

        public override string[] Validar()
        {
            List<string> erros = new();

            if (valor <= 0)
                erros.Add("O valor precisa ser número positivo.");

            if (string.IsNullOrEmpty(nome))
                erros.Add("É necessário incluir o nome do Item.");

            return erros.ToArray();
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
