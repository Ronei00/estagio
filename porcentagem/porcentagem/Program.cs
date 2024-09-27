float sp = 67836.43F;
float rj = 36678.66F;
float mg = 29229.88F;
float es = 27165.48F;
float outro = 19849.53F;

float total = sp + rj + mg + es + outro;

Console.WriteLine($"{(sp / total) * 100:F2}");
Console.WriteLine($"{(rj / total) * 100:F2}");
Console.WriteLine($"{(mg / total) * 100:F2}");
Console.WriteLine($"{(es / total) * 100:F2}");
Console.WriteLine($"{(outro / total) * 100:F2}");