int fibo = 0;
int temp;
Console.WriteLine("Por favor digite um número!!");

string valordigitado = Console.ReadLine();

while (valordigitado == "")
{
    Console.WriteLine("Por favor digite um número!!");

    valordigitado = Console.ReadLine();
}

if (valordigitado != "") 
{
    int digitado = int.Parse(valordigitado);

    for (int i = 1; fibo < digitado;)
    {
        temp = fibo;
        fibo = i + fibo;
        i = temp;
        if (fibo == digitado)
        {
        Console.WriteLine("Valor digitado pertence a fibonacci");
        }
    }

    if(fibo > digitado)
    {
    Console.WriteLine("Valor digitado não pertence a fibonacci");
    }
}