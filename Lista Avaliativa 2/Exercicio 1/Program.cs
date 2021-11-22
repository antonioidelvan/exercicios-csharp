int tamanho = 10;

float[] numeroQualquer = new float[tamanho];

for (int i = 0; i < numeroQualquer.Length; i++)
{
    Console.Write("Digite um valor qualquer: ");
    numeroQualquer[i] = float.Parse(Console.ReadLine());
}

Console.WriteLine("Os valores digitados foram: ");

for (int i = 0; i < numeroQualquer.Length; i++)
{
    Console.WriteLine(numeroQualquer[i]);
}