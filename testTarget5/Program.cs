string original = "Exemplo de string";

char[] caracteres = original.ToCharArray();

for (int i = 0, j = caracteres.Length - 1; i < j; i++, j--)
{
    char temp = caracteres[i];
    caracteres[i] = caracteres[j];
    caracteres[j] = temp;
}

string invertida = new string(caracteres);

Console.WriteLine("Original: " + original);
Console.WriteLine("Invertida: " + invertida);