using System;
// Numa loja de eletrodomésticos, as compras têm um preço à vista, ou acréscimo de 10% para pagamentos em 2 vezes, ou ainda, acréscimo de 20% para pagamento em 3 vezes. Faça um programa em C# que solicita ao usuário o valor da compra à vista e a opção de compra, e, posteriormente, calcula e exibe qual o valor final a ser pago. 

namespace exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorNormal;
            int numeroParcelas;

            Console.Write("Qual o valor do produto? R$ ");
            valorNormal = float.Parse(Console.ReadLine());
            
            Console.Write("Quantas parcelas? ");
            numeroParcelas = int.Parse(Console.ReadLine());

            switch (numeroParcelas) 
            {
                case 1:
                    Console.WriteLine("Você ira pagar R$ " + valorNormal);
                    break;
                case 2:
                    Console.WriteLine("Você ira pagar R$ " + (valorNormal * 1.10));
                    break;
                case 3:
                    Console.WriteLine("Você ira pagar R$ " + (valorNormal * 1.20));
                    break;
                default:
                    Console.WriteLine("Número de parcelas não suportado");
                    break;
            }
        }
    }
}
