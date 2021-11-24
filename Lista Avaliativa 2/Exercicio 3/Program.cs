int tamanho = 5;

int[] primeiroVetor = new int[tamanho];
int[] segundoVetor = new int[tamanho];
int[] juncaoVetor = new int[10];

int primeiroIndex = 0, segundoIndex = 0;

for (int i = 0; i < tamanho; i++)
{
    Console.Write("Digite um valor inteiro para o Primeiro vetor: ");
    primeiroVetor[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < tamanho; i++)
{
    Console.Write("Digite um valor inteiro para o Segundo vetor: ");
    segundoVetor[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        juncaoVetor[i] = primeiroVetor[primeiroIndex];
        primeiroIndex++;
    }
    else
    {
        juncaoVetor[i] = segundoVetor[segundoIndex];
        segundoIndex++;
    }

}

foreach (int valores in juncaoVetor)
{
    Console.WriteLine(valores);
}