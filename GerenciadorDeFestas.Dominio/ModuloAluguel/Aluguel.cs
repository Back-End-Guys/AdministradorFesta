using GerenciadorDeFestas.Dominio.Compartilhado;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloTema;
using System.Text.RegularExpressions;

namespace GerenciadorDeFestas.Dominio.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {
        public Cliente cliente;
        public Tema tema;
        public DateTime data;
        public DateTime horaInicio;
        public DateTime horaFinal;
        public DateTime dataFechamento;
        public string Cep;
        public string numero;
        public string nomeRua;

        public bool pagamento;
        public decimal ValorAhPagar;
        public PorcentagemPagaEnum porcentagemPaga;        

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
            this.ValorAhPagar = registroAtualizado.ValorAhPagar;
        }

        public void AtualizarPagamento(Aluguel aluguelAtualizado)
        {
            this.porcentagemPaga = aluguelAtualizado.porcentagemPaga;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (cliente == null)
                erros.Add("O campo 'Cliente' é obrigatório");

            if (tema == null)
                erros.Add("O campo 'Tema' é obrigatório");

            string apenasDigitos = Regex.Replace(Cep, "[^0-9]", "");

            if (string.IsNullOrEmpty(apenasDigitos))            
                erros.Add("O campo 'Cep' é obrigatório");

            if (apenasDigitos.Length < 8)
                erros.Add("'Cep' incompleto.");

            if (string.IsNullOrEmpty(nomeRua))            
                erros.Add("O campo 'Rua' é obrigatório");            

            if (string.IsNullOrEmpty(numero))            
                erros.Add("O campo 'Número' é obrigatório");
            

            return erros.ToArray();
        }

        public decimal CalcularDesconto()
        {
            if (cliente.clienteAntigo)
            {
                return tema.valorTotal * (decimal)0.90;
            }

            return tema.valorTotal;
        }

        public decimal CalcularValorAhPagar()
        {
            decimal valorAhPagar = CalcularDesconto();

            valorAhPagar = valorAhPagar - (valorAhPagar * (decimal)porcentagemPaga / 100);

            return valorAhPagar;
        }

        public void FinalizarPagamento()
        {
            if (porcentagemPaga == PorcentagemPagaEnum.Cem)
            {
                dataFechamento = DateTime.Now.Date;
            }
        }
    }
}
