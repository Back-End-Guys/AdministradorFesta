using GerenciadorDeFestas.Dominio.ModuloCliente;
using System.Text.Json;
using System.Text.Json.Serialization;
using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.Dominio.ModuloAluguel;

namespace GerenciadorDeFestas.Infra.Dados.Arquivo.Compartilhado
{
    public class ContextoDados
    {
        private const string NOME_ARQUIVO = "Compartilhado\\Festas.json";


        public List<Cliente> listaClientes;
        public List<Tema> listaTemas;
        public List<Item> listaItens;
        public List<Aluguel> listaAluguel;

        public ContextoDados()
        {
            listaClientes = new List<Cliente>();
            listaItens = new List<Item>();
            listaTemas = new List<Tema>();
            listaAluguel = new List<Aluguel>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            string registrosJson = JsonSerializer.Serialize(this, config);

            File.WriteAllText(NOME_ARQUIVO, registrosJson);
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(NOME_ARQUIVO))
            {
                string registrosJson = File.ReadAllText(NOME_ARQUIVO);

                if (registrosJson.Length > 0)
                {
                    ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosJson, config);

                    this.listaClientes = ctx.listaClientes;
                    this.listaTemas = ctx.listaTemas;
                    this.listaItens = ctx.listaItens;
                    this.listaAluguel = ctx.listaAluguel;
                }
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
