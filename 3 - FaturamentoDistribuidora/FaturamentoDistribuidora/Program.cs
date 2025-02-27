using FaturamentoDistribuidora.Models;
using FaturamentoDistribuidora.Services;
using System.Text.Json;

namespace FaturamentoDistribuidora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler o arquivo JSON
            var json = File.ReadAllText("Data/dados.json");
            var faturamentos = JsonSerializer.Deserialize<List<FaturamentoDiario>>(json);

            // Calcular e exibir os resultados
            CalculadoraFaturamento.Calcular(faturamentos);
        }
    }
}