using System;

namespace Lista_Avaliativa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio1();
            // Exercicio2();
            // Exercicio3();
            // Exercicio4();
            // Exercicio5();
            // Exercicio6();
            // Exercicio7();
            // Exercicio8();
            // Exercicio9();
            // Exercicio10();
        }

        static void Exercicio1()
        {
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
        }

        static void Exercicio2()
        {
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
        }

        static void Exercicio3()
        {
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
        }

        static void Exercicio4()
        {
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
        }

        static void Exercicio5()
        {
            int totalPecas = 0;

            int[] quantidadePecasVendidas = new int[10];
            float[] precoCadaPeca = new float[10];
            float[] totalVenda = new float[10];

            for(int i = 0; i < 10; i++)
            {
                Console.Write("Quantas peças o Vendedor {0} vendeu? ", i);
                quantidadePecasVendidas[i] = int.Parse(Console.ReadLine());

                Console.Write("Qual é o valor de cada peça que o vendedor {0} vendeu? ", i);
                precoCadaPeca[i] = float.Parse(Console.ReadLine());
            }

            for(int i = 0; i < quantidadePecasVendidas.Length; i++)
            {
                totalPecas += quantidadePecasVendidas[i];
            }

            for(int i = 0; i < 10; i++)
            {
                totalVenda[i] = quantidadePecasVendidas[i] * precoCadaPeca[i];
            }

            Console.Clear();

            Console.WriteLine("Foi vendido um total de {0} peças.", totalPecas);

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(" O vendedor {0} faturou um total de R$ {1}", i, totalVenda[i]);
            }
        }

        static void Exercicio6()
        {

        }
    }
}
