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
        public string status = "Aberto";

        public decimal valorTotal;
        public decimal valorPago;
        public decimal valorPendente;

        public bool pagamento;
        public PorcentagemPagaEnum porcentagemPaga;

        public Aluguel(Cliente cliente, Tema tema, DateTime data, DateTime horaInicio, DateTime horaFinal, string cep, string numero, string nomeRua)
        {
            this.cliente = cliente;
            this.tema = tema;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
            this.Cep = cep;
            this.numero = numero;
            this.nomeRua = nomeRua;
        }

        //public Aluguel(Cliente cliente, Tema tema, DateTime data, DateTime horaInicio, DateTime horaFinal, string cep, string numero, string nomeRua)
        //{
        //    this.cliente = cliente;
        //    this.tema = tema;
        //    this.data = data;
        //    this.horaInicio = horaInicio;
        //    this.horaFinal = horaFinal;
        //    Cep = cep;
        //    this.numero = numero;
        //    this.nomeRua = nomeRua;
        //}

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
            //this.nomeRua = registroAtualizado.nomeRua;
            //this.valorPendente = registroAtualizado.valorPendente;
            //this.valorTotal = registroAtualizado.valorTotal;
            //this.valorPago = registroAtualizado.valorPago;
            //this.porcentagemPaga = registroAtualizado.porcentagemPaga;
        }

        public void AtualizarPagamento(Aluguel aluguelAtualizado)
        {
            this.porcentagemPaga = aluguelAtualizado.porcentagemPaga;
        }

        //public void AtualizarValoresDoPagamento(Aluguel aluguelSelecionado)
        //{
        //    this.valorTotal = aluguelSelecionado.valorTotal;
        //    this.valorPago = aluguelSelecionado.valorPago;
        //    this.valorPendente = aluguelSelecionado.valorPendente;
        //    this.porcentagemPaga = aluguelSelecionado.porcentagemPaga;
        //}

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

        public decimal CalcularDesconto(decimal valorTotal)
        {
            if (cliente.clienteAntigo)
            {
                return valorTotal * (decimal)0.90;
            }

            return valorTotal;
        }

        public decimal CalcularValorPendente()
        {
            decimal valorPendente = CalcularDesconto(valorTotal);

            valorPendente = valorPendente - (valorPendente * (decimal)porcentagemPaga / 100);

            return valorPendente;
        }

        public decimal CalcularValorPago(decimal valorTotal, decimal porcentagemPaga)
        {
            return valorTotal * (decimal)porcentagemPaga / 100;
        }

        public decimal CalcularValorPago()
        {
            return valorTotal * (decimal)porcentagemPaga / 100;
        }

        public void FinalizarPagamento()
        {
            if (porcentagemPaga == PorcentagemPagaEnum.Cem)
            {
                dataFechamento = DateTime.Now.Date;
                status = "Fechado";
            }
        }
    }
}
