using GerenciadorDeFestas.Dominio.Compartilhado;

namespace GerenciadorDeFestas.Dominio.ModuloItem
{
    [Serializable]
    public class Item : EntidadeBase<Item>
    {
        public string nome;
        public decimal valor;

        public Item(string nome, decimal valor)
        {
            this.nome = nome;
            this.valor = valor;
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

            else if (string.IsNullOrEmpty(nome))
                erros.Add("É necessário incluir o nome do Item.");

            return erros.ToArray();
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
