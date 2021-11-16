using System;
//Escreva um programa em C# que receba o número de lados de um polígono regular, e a medida de cada lado. Calcular e exibir o seguinte: Se o número de lados for igual a 3, escrever TRIÂNGULO e verificar sua classificação (equilátero, isósceles ou escaleno). Se o número de lados for igual a 4, escrever QUADRILÁTERO, verificar se é um quadrado e calcular o valor da sua área. Se o número de lados for igual a 5, escrever PENTÁGONO e o valor do seu perímetro. Em qualquer outra situação, escrever polígono não-identificado. 


namespace exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeLados;
            float medidaLado, areaQuadrado, perimetroPentagono;

            Console.Write("Qual a quantidade de lados? ");
            quantidadeLados = int.Parse(Console.ReadLine());

            Console.Write("Qual a medida dos lados? ");
            medidaLado = float.Parse(Console.ReadLine());

            switch (quantidadeLados)
            {
                case 3:
                    Console.WriteLine("Esse polígono é um Triângulo equilátero");
                break;

                case 4:
                    Console.WriteLine("Esse polígono é um Quadrilátero quadrado");
                    areaQuadrado = (medidaLado * 2);
                    Console.WriteLine("A área do quadrado é " + areaQuadrado);
                break;

                case 5:
                    Console.WriteLine("Esse polígono é um Pentágono");
                    perimetroPentagono = (medidaLado * 5);
                    Console.WriteLine("O perímetro do Pentágono é " + perimetroPentagono);
                break;

                default:
                    Console.WriteLine("Polígono não-identificado");
                break;
            }
        }
    }
}
