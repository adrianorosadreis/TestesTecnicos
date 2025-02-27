using FaturamentoDistribuidora.Models;

namespace FaturamentoDistribuidora.Services
{
    public class CalculadoraFaturamento
    {
        public static void Calcular(List<FaturamentoDiario> faturamentos)
        {
            // Ignorar dias sem faturamento
            var faturamentosValidos = faturamentos.Where(f => f.valor > 0).ToList();

            // Menor valor de faturamento
            var menorFaturamento = faturamentosValidos.Min(f => f.valor);
            Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");

            // Maior valor de faturamento
            var maiorFaturamento = faturamentosValidos.Max(f => f.valor);
            Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");

            // Média mensal
            var mediaMensal = faturamentosValidos.Average(f => f.valor);
            Console.WriteLine($"Média mensal: {mediaMensal}");

            // Número de dias com faturamento acima da média
            var diasAcimaDaMedia = faturamentosValidos.Count(f => f.valor > mediaMensal);
            Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
        }
    }
}