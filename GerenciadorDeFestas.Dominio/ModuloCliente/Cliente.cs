using GerenciadorDeFestas.Dominio.Compartilhado;
using GerenciadorDeFestas.Dominio.ModuloAluguel;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace GerenciadorDeFestas.Dominio.ModuloCliente
{
    [Serializable]
    public class Cliente : EntidadeBase<Cliente>
    {
        public string nome;
        public string telefone;
        public List<Aluguel> alugueis;

        public Cliente(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.alugueis = new List<Aluguel>();
        }

        public Cliente()
        {
        }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.telefone = registroAtualizado.telefone;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");

            string apenasDigitos = Regex.Replace(telefone, "[^0-9]", "");

            if (string.IsNullOrEmpty(apenasDigitos))
                erros.Add("O campo 'telefone' é obrigatório");

            if (telefone.Length <= 14)
                erros.Add("O campo 'telefone' é obrigatório");

            if (nome.Length < 5)
                erros.Add("O campo 'nome' deve ter no mínimo 5 caracteres");
            

            return erros.ToArray();
        }

        public override bool Equals(object? obj)
        {
            return obj is Cliente cliente &&
                   id == cliente.id &&
                   nome == cliente.nome &&
                   telefone == cliente.telefone;
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
