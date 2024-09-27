using System.Text.Json;

Random rando = new Random();
string[] faturamentoMes = new string[21];
int mediaMensal = 0;

for (int i = 0; i <= 20; i++)
{
    faturamentoMes[i] = rando.Next(10000).ToString();
}

int[] valores = faturamentoMes.Select(s => int.Parse(s)).ToArray();
int maiorValor = valores.Max();
int menorValor = valores.Min();

for(int i = 0; i < valores.Length; i++)
{
    if (valores[i] == maiorValor)
    {
        Console.WriteLine("maior Valor de faturamento = " + maiorValor + " do dia " + (i + 1));
    }
    if (valores[i] == menorValor)
    {
        Console.WriteLine("menor Valor de faturamento = " + menorValor + " do dia " + (i + 1));
    }
}

foreach (string s in faturamentoMes)
{
    mediaMensal += int.Parse(s);
}

mediaMensal = mediaMensal / 30;
Console.WriteLine("Média de faturamento do Mês = " + mediaMensal);
for (int i = 0; i < valores.Length; i++)
{
    if (valores[i] > mediaMensal)
    {
        Console.WriteLine("valores de faturamento acima da média do mês = " + valores[i] + " do dia " + (i + 1));
    }
}
string json = JsonSerializer.Serialize(valores);
Console.WriteLine(json);
