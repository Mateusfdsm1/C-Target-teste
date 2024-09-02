//3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
//• O menor valor de faturamento ocorrido em um dia do mês;
//• O maior valor de faturamento ocorrido em um dia do mês;
//• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
//
//IMPORTANTE:
//a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
//b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Program
{
    public class FaturamentoDiario
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }

    static void Main()
    {

        string json = File.ReadAllText("faturamento.json");

        List<FaturamentoDiario> faturamentos = JsonConvert.DeserializeObject<List<FaturamentoDiario>>(json);

        var diasComFaturamento = faturamentos.Where(f => f.Valor > 0).ToList();

        double menorFaturamento = diasComFaturamento.Min(f => f.Valor);

        double maiorFaturamento = diasComFaturamento.Max(f => f.Valor);

        double mediaMensal = diasComFaturamento.Average(f => f.Valor);

        
        int diasAcimaDaMedia = diasComFaturamento.Count(f => f.Valor > mediaMensal);

        
        Console.WriteLine($"Menor valor de faturamento em um dia do mês: {menorFaturamento}");
        Console.WriteLine($"Maior valor de faturamento em um dia do mês: {maiorFaturamento}");
        Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
    }
}
