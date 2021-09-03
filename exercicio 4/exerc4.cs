using System;
// Um comerciante comprou um produto e quer vendê-lo com um lucro de 45% se o valor da compra for menor que R$ 20,00; caso contrário, o lucro será de 30%. Elabore um programa em C# que leia o valor do produto e imprima o valor de venda para o produto.

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorProduto;
            float valorAcrecimo;
            float valorFinal;

            int porcentagem = 100;
            int porcentagem45 = 45;
            int porcentagem30 = 30;

            Console.WriteLine("Qual o valor do produto que será vendido? ");
            valorProduto = float.Parse(Console.ReadLine());

            if(valorProduto <= 20) {
                valorAcrecimo = valorProduto ;

                valorAcrecimo = valorProduto * porcentagem45/porcentagem;
                valorFinal = valorProduto + valorAcrecimo;

                Console.WriteLine("O produto deve ser vendido por R$ " + valorFinal);
            }
            else {
                valorAcrecimo = valorProduto ;

                valorAcrecimo = valorProduto * porcentagem30/porcentagem;
                valorFinal = valorProduto + valorAcrecimo;

                Console.WriteLine("O produto deve ser vendido por R$ " + valorFinal);
            }
        }
    }
}
