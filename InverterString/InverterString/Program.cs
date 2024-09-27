string text2 = "";
Console.WriteLine("escreva uma frase para colocar invertida");
string text = Console.ReadLine();

char[] array = text.ToCharArray();
int j = array.Length - 1;

for (int i = 0; i < array.Length; i++)
{
    
    text2 += array[j];
    j--;
}
Console.WriteLine(text2);