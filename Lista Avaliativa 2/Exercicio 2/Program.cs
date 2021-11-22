const int tamanho = 10, tamanhoPar = 10, tamanhoImpar = 10;
int quantidadePares = 0, quantidadeImpares = 0;

int[] numeroQualquer = new int[tamanho];

int[] numerosPares = new int[tamanhoPar];
int[] numerosImpares = new int[tamanhoImpar];

for (int i = 0; i < tamanho; i++)
{
    Console.Write("Digite um valor qualquer: ");
    numeroQualquer[i] = int.Parse(Console.ReadLine());

    if (numeroQualquer[i] % 2 == 0)
    {
        numerosPares[quantidadePares] = numeroQualquer[i];
        quantidadePares++;
    }
    else
    {
        numerosImpares[quantidadeImpares] = numeroQualquer[i];
        quantidadeImpares++;
    }
}

for (int i = 0; i < quantidadePares; i++)
{
    Console.WriteLine("Os números pares digitados são: {0} ", numerosPares[i]);
}

for (int i = 0; i < quantidadeImpares; i++)
{
    Console.WriteLine("Os números impares digitados são: {0} ", numerosImpares[i]);
}