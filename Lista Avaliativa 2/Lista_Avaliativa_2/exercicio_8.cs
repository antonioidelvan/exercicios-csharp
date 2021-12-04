using System;
/* Atividade Avaliativa 2 - Exercício 8
 * Faça um programa C# que receba a idade, o peso e a altura de cada um dos 
 * jogadores dos cinco times que estão competindo um campeonato de futebol 
 * (cada time possui onze jogadores), calcule e mostre:
* a quantidade de jogadores com idade inferior a 18 anos;
* a média das idades dos jogadores de cada time;
* a média das alturas de todos os jogadores do campeonato;
* a porcentagem de jogadores com mais de 80 quilos entre todos os jogadores 
* do campeonato.*/

namespace Exercicio8Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            int i, j, idade, qtde_menor18, qtde_maior80;
            //i=contador dos times
            //j=contador dos jogadores
            float peso, altura, soma_idades, soma_alturas, media_idades, media_alturas, porcentagem;
            qtde_menor18 = 0;
            qtde_maior80 = 0;
            soma_alturas = 0;
            //Para cada time
            for (i = 1; i <= 2; i++)
            {
                soma_idades = 0;
                Console.WriteLine("TIME " + i);
                for (j = 1; j <= 2; j++)
                {
                    //Leitura da idade, do peso e da altura de cada jogador
                    Console.Write("Informe a idade do jogador " + i + " do time " + j + ": ");
                    idade = int.Parse(Console.ReadLine());
                    Console.Write("Informe o peso do jogador " + i + " do time " + j + ": ");
                    peso = float.Parse(Console.ReadLine());
                    Console.Write("Informe a altura do jogador " + i + " do time " + j + ": ");
                    altura = float.Parse(Console.ReadLine());
                    //Cálculo da quantidade de jogadores com idade inferior a 18 anos
                    if (idade < 18)
                    {
                        qtde_menor18 = qtde_menor18 + 1;
                    }
                    //Cálculo da quantidade de jogadores com mais de 80 quilos
                    if (peso > 80)
                    {
                        qtde_maior80 = qtde_maior80 + 1;
                    }
                    //Soma das alturas e das idades para cálculo das médias
                    soma_alturas = soma_alturas + altura;
                    soma_idades = soma_idades + idade;
                }//Fim do for dos jogadores
                media_idades = soma_idades / 2;
                Console.WriteLine("A média das idades dos jogadores do time " + i + " é " + media_idades);
            }//Fim do for dos times
             //Cálculo da média e da porcentagem
            media_alturas = soma_alturas / 4;
            porcentagem = qtde_maior80 * 100 / 4;
            //Exibir os resultados
            Console.WriteLine("A quantidade de jogadores com idade inferior a 18 anos é " + qtde_menor18);
            Console.WriteLine("A média das alturas de todos os jogadores do campeonato é " + media_alturas);
            Console.WriteLine("A porcentagem de jogadores com mais de 80 quilos entre todos os jogadores do campeonato é " + porcentagem + "%");
        }
    }
}