using System;
/* Atividade Avaliativa - Exercício 9
 * Elabore um programa C# que carregue uma matriz 10 x 20 com números inteiros e 
 * some cada uma das linhas, armazenando o resultado das somas em um vetor. 
 * A seguir, multiplique cada elemento da matriz pela soma da linha e mostre 
 * a matriz resultante.*/

namespace Exercicio9Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            int i, j, soma, NL = 10, NC = 20;
            int[,] matriz = new int[NL,NC];
            int[] vetor = new int[NL];
            int[,] matrizRes = new int[NL,NC];

            //Leitura da matriz e cálculo da soma
            Console.WriteLine("Digite uma matriz 10 x 20:");
            for (i = 0; i < NL; i++)
            {
                soma = 0;
                for (j = 0; j < NC; j++)
                {
                    Console.Write("Posição [" + i + "," + j + "]: ");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                    soma = soma + matriz[i,j];
                }
                vetor[i] = soma;
            }
            // Exibir o vetor - soma das linhas
            Console.WriteLine("O vetor resultante da soma de cada linha da matriz é: ");
            for (i = 0; i < NL; i++)
            {
                Console.WriteLine(vetor[i]);
            }   
            //Efetuar a multiplicação e exibir a matriz resultante
            Console.WriteLine("A matriz resultante é:");
            for (i = 0; i < NL; i++)
            {
                for (j = 0; j < NC; j++)
                {
                    matrizRes[i,j] = vetor[i] * matriz[i,j];
                    Console.Write("\t" + matrizRes[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}