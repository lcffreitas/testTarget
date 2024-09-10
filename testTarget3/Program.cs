using Newtonsoft.Json;
using testTarget3;

public class Program
{
    private static void Main(string[] args)
    {
        string jsonFilePath = "C:/tests/testTarget/testTarget3/faturamento.json";
        string jsonData = File.ReadAllText(jsonFilePath);

        List<FaturamentoDiario> faturamentos = JsonConvert.DeserializeObject<List<FaturamentoDiario>>(jsonData);

        var diasComFaturamento = faturamentos.Where(f => f.Faturamento > 0).ToList();

        double menorFaturamento = diasComFaturamento.Min(f => f.Faturamento);

        double maiorFaturamento = diasComFaturamento.Max(f => f.Faturamento);

        double mediaMensal = diasComFaturamento.Average(f => f.Faturamento);

        int diasAcimaDaMedia = diasComFaturamento.Count(f => f.Faturamento > mediaMensal);

        // Exibe os resultados
        Console.WriteLine($"Menor valor de faturamento: R$ {menorFaturamento:0.00}");
        Console.WriteLine($"Maior valor de faturamento: R$ {maiorFaturamento:0.00}");
        Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
    }
}