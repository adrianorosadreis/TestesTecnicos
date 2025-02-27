class Program
{
    static void Main()
    {
        // Dados de faturamento por estado armazenados em um dicionário
        Dictionary<string, double> faturamentoPorEstado = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        // Calculando o faturamento total
        double faturamentoTotal = 0;
        foreach (var valor in faturamentoPorEstado.Values)
        {
            faturamentoTotal += valor;
        }

        // Calculando e exibindo o percentual de representação de cada estado
        Console.WriteLine("Percentual de representação por estado:");
        foreach (var estado in faturamentoPorEstado)
        {
            double percentual = (estado.Value / faturamentoTotal) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}