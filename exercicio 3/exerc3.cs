using System;
// Elabore um programa em C# que leia um número e, se ele for positivo, imprima a metade desse número, caso contrário imprima o número ao quadrado. 

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float numeroAleatorio;
            
            Console.WriteLine("Digite um número qualquer: ");
            numeroAleatorio = float.Parse(Console.ReadLine());

            if(numeroAleatorio > 0) {
                Console.WriteLine("A metade do número digitado é " + (numeroAleatorio/2) );
            }

            else if(numeroAleatorio == 0){
                Console.WriteLine("O número digitado é zero");
            }
            else {
                Console.WriteLine("O quadrado do número digitado é -" + (numeroAleatorio * numeroAleatorio) );
            }
        }
    }
}
