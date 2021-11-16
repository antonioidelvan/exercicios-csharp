using System;
// Faça  um  programa  em  C#  que  leia  o  valor  de  uma  mercadoria  e  a porcentagem  de  desconto.  O  algoritmo  deverá  calcular  e  mostrar  o  valor  da mercadoria a ser paga considerando o desconto concedido.

namespace exercicios_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Valor da mercadoria
            float mercadoriaValor;
            // Porcentagem de desconto
            float porcentagemDesconto;
            // Valor final com desconto
            float valorDesconto;
            // Valor fixo para porcentagem
            int porcentagem = 100;
            // Valor final
            float valorFinal;

            Console.WriteLine("Qual o valor da mercadoria?");
            mercadoriaValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual a % de desconto?");
            porcentagemDesconto = float.Parse(Console.ReadLine());

            valorDesconto = mercadoriaValor * porcentagemDesconto/porcentagem;
            valorFinal = mercadoriaValor - valorDesconto;

            Console.WriteLine("Você ira pagar: R$ " + valorFinal);
        }
    }
}
