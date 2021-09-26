using System;
//Elabore um programa em C# que leia 200 números, e imprima quantos são pares e quantos são ímpares. 

namespace exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0, impar = 0, i, numero;
            Random numeroAleatorio = new Random();

            for (i = 1; i <= 200; i++)
            {
                numero = (numeroAleatorio.Next(0,200));
                Console.WriteLine(numero);

                if (numero % 2 == 0)
                {
                    par++;
                }
                
                else
                {
                    impar++;
                }
                
            }
            Console.WriteLine("A quantidade de pares é " + par + " e a quantidade de impares é " + impar);
        }
    } 
}
