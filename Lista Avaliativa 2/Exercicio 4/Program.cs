int tamanho = 13;
float maior = 0;
float[] vetor = new float[tamanho];
float[] resultadoVetor = new float[tamanho];

Console.Write("Digite um valor inteiro qualquer: ");
vetor[0] = float.Parse(Console.ReadLine());

maior = vetor[0];

for (int i = 1; i < vetor.Length; i++)
{
    Console.Write("Digite um valor inteiro qualquer: ");
    vetor[i] = float.Parse(Console.ReadLine());

if (vetor[i] > maior)
{
    maior = vetor[i];
}

}

for (int i = 0; i < vetor.Length; i++)
{
    resultadoVetor[i] = vetor[i] / maior;
}

foreach (float vetorResultado in resultadoVetor)
{
    Console.WriteLine(vetorResultado);
}