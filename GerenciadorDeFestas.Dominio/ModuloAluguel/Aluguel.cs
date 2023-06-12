using GerenciadorDeFestas.Dominio.Compartilhado;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloTema;

namespace GerenciadorDeFestas.Dominio.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {
        public Cliente cliente;
        public Tema tema;
        public DateTime data;
        public DateTime horaInicio;
        public DateTime horaFinal;
        public string Cep;
        public string numero;
        public string nomeRua;

        public bool pagamento;

        public Aluguel(Cliente cliente, Tema tema, DateTime data, DateTime horaInicio, DateTime horaFinal, string cep, string numero, string nomeRua)
        {
            this.cliente = cliente;
            this.tema = tema;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
            Cep = cep;
            this.numero = numero;
            this.nomeRua = nomeRua;

        }

        public Aluguel()
        {

        }

        public override void AtualizarInformacoes(Aluguel registroAtualizado)
        {
            this.cliente = registroAtualizado.cliente;
            this.tema = registroAtualizado.tema;
            this.data = registroAtualizado.data;
            this.horaInicio = registroAtualizado.horaInicio;
            this.horaFinal = registroAtualizado.horaFinal;
            this.Cep = registroAtualizado.Cep;
            this.numero = registroAtualizado.numero;
            this.nomeRua = registroAtualizado.nomeRua;

        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if(string.IsNullOrEmpty(Cep))
            {
                erros.Add("O campo 'Cep' é obrigatório");
            }

            if (string.IsNullOrEmpty(nomeRua))
            {
                erros.Add("O campo 'Rua' é obrigatório");
            }

            if (string.IsNullOrEmpty(numero))
            {
                erros.Add("O campo 'Número' é obrigatório");
            }

            return erros.ToArray();

        }
    }
}
