using System;
// Elabore um programa em C# que leia um número de entrada que indicará a quantidade de números a serem lidos. Em seguida, leia n números (conforme o valor informado anteriormente) e, ao final imprima o maior, o menor, e a média dos números digitados.

namespace exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, quantidadeNumeros;
            float numero, maior, menor, media, soma;

            Console.Write("Quantos números você deseja digitar? ");
            quantidadeNumeros = int.Parse(Console.ReadLine());

            Console.Write("Digite um número: ");
            numero = float.Parse(Console.ReadLine());

            maior = numero;
            menor = numero;
            soma = numero;

            while (i < quantidadeNumeros) {
                
                Console.Write("Digite um número: ");
                numero = float.Parse(Console.ReadLine());
                soma = soma + numero;
                
                if (numero >= maior)
                {
                    maior = numero;
                }
                
                else if (numero <= menor)
                {
                    menor = numero;
                }
                
                i++;
            }
            media = soma / quantidadeNumeros;

            Console.WriteLine("O maior, o menor e a média dos números digitados é respectivamente " + maior + " ," + menor + " e " + media + ".");
        }
    }
}
