using System;
// A importância de R$ 780.000,00 será dividida entre os três primeiros colocados de um concurso, em partes diretamente proporcionais aos pontos conseguidos por eles. Construa um programa em C# que solicite o número de pontos dos três primeiros colocados e mostre a importância que caberá a cada um. Observação: a porcentagem de cada colocado é dada pela quantidade de pontos do colocado dividido pela quantidade total de pontos dos três colocados.

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float quantidadePontos1, quantidadePontos2, quantidadePontos3, importancia = 780000, pontosTotais, premio1Lugar, premio2Lugar, premio3Lugar;

            Console.Write("Qual a quantidade de pontos do primeiro colocado? ");
            quantidadePontos1 = float.Parse(Console.ReadLine());

            Console.Write("Qual a quantidade de pontos do segundo colocado? ");
            quantidadePontos2 = float.Parse(Console.ReadLine());

            Console.Write("Qual a quantidade de pontos do terceiro colocado? ");
            quantidadePontos3 = float.Parse(Console.ReadLine());

            pontosTotais = quantidadePontos1 + quantidadePontos2 + quantidadePontos3;

            premio1Lugar = (quantidadePontos1 / pontosTotais) * importancia;
            premio2Lugar = (quantidadePontos2 / pontosTotais) * importancia;
            premio3Lugar = (quantidadePontos3 / pontosTotais) * importancia;

            Console.WriteLine("Os 3 colocados ficaram respectivamente com " + premio1Lugar + ", " + premio2Lugar + " e " + premio3Lugar);
        }
    }
}
