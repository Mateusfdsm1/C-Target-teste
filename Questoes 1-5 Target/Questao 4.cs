//4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
//• SP – R$67.836,43
//• RJ – R$36.678,66
//• MG – R$29.229,88
//• ES – R$27.165,48
//• Outros – R$19.849,53

//Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora. 


using System;

class Program
{
    static void Main()
    {

        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;

        double total = sp + rj + mg + es + outros;

        double percentualSP = (sp / total) * 100;
        double percentualRJ = (rj / total) * 100;
        double percentualMG = (mg / total) * 100;
        double percentualES = (es / total) * 100;
        double percentualOutros = (outros / total) * 100;

        Console.WriteLine($"Percentual de SP: {percentualSP:F2}%");
        Console.WriteLine($"Percentual de RJ: {percentualRJ:F2}%");
        Console.WriteLine($"Percentual de MG: {percentualMG:F2}%");
        Console.WriteLine($"Percentual de ES: {percentualES:F2}%");
        Console.WriteLine($"Percentual de Outros: {percentualOutros:F2}%");
    }
}