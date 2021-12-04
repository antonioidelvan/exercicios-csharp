using System;

namespace Lista_Avaliativa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio1();
            // Exercicio2();
            // Exercicio3();
            // Exercicio4();
            // Exercicio5();
            // Exercicio6();
            // Exercicio7();
            // Exercicio8();
            // Exercicio9();
            // Exercicio10();
        }

        static void Exercicio1()
        {
            int tamanho = 10;

            float[] numeroQualquer = new float[tamanho];

            for (int i = 0; i < numeroQualquer.Length; i++)
            {
                Console.Write("Digite um valor qualquer: ");
                numeroQualquer[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Os valores digitados foram: ");

            for (int i = 0; i < numeroQualquer.Length; i++)
            {
                Console.WriteLine(numeroQualquer[i]);
            }
        }

        static void Exercicio2()
        {
            const int tamanho = 10, tamanhoPar = 10, tamanhoImpar = 10;
            int quantidadePares = 0, quantidadeImpares = 0;

            int[] numeroQualquer = new int[tamanho];

            int[] numerosPares = new int[tamanhoPar];
            int[] numerosImpares = new int[tamanhoImpar];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Digite um valor qualquer: ");
                numeroQualquer[i] = int.Parse(Console.ReadLine());

                if (numeroQualquer[i] % 2 == 0)
                {
                    numerosPares[quantidadePares] = numeroQualquer[i];
                    quantidadePares++;
                }
                else
                {
                    numerosImpares[quantidadeImpares] = numeroQualquer[i];
                    quantidadeImpares++;
                }
            }

            for (int i = 0; i < quantidadePares; i++)
            {
                Console.WriteLine("Os números pares digitados são: {0} ", numerosPares[i]);
            }

            for (int i = 0; i < quantidadeImpares; i++)
            {
                Console.WriteLine("Os números impares digitados são: {0} ", numerosImpares[i]);
            }
        }

        static void Exercicio3()
        {
            int tamanho = 5;

            int[] primeiroVetor = new int[tamanho];
            int[] segundoVetor = new int[tamanho];
            int[] juncaoVetor = new int[10];

            int primeiroIndex = 0, segundoIndex = 0;

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Digite um valor inteiro para o Primeiro vetor: ");
                primeiroVetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Digite um valor inteiro para o Segundo vetor: ");
                segundoVetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    juncaoVetor[i] = primeiroVetor[primeiroIndex];
                    primeiroIndex++;
                }
                else
                {
                    juncaoVetor[i] = segundoVetor[segundoIndex];
                    segundoIndex++;
                }

            }

            foreach (int valores in juncaoVetor)
            {
                Console.WriteLine(valores);
            }
        }

        static void Exercicio4()
        {
            int tamanho = 15;
            float maior = 0;
            float[] vetor = new float[tamanho];
            float[] resultadoVetor = new float[tamanho];

            Console.Write("Digite um valor inteiro qualquer: ");
            vetor[0] = float.Parse(Console.ReadLine());

            maior = vetor[0];

            for (int i = 1; i < vetor.Length; i++)
            {
                Console.Write("Digite um valor inteiro qualquer: ");
                vetor[i] = float.Parse(Console.ReadLine());

                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }

            }

            for (int i = 0; i < vetor.Length; i++)
            {
                resultadoVetor[i] = vetor[i] / maior;
            }

            foreach (float vetorResultado in resultadoVetor)
            {
                Console.WriteLine(vetorResultado);
            }
        }

        static void Exercicio5()
        {
            int totalPecas = 0;

            int[] quantidadePecasVendidas = new int[10];
            float[] precoCadaPeca = new float[10];
            float[] totalVenda = new float[10];

            for(int i = 0; i < 10; i++)
            {
                Console.Write("Quantas peças o Vendedor {0} vendeu? ", i);
                quantidadePecasVendidas[i] = int.Parse(Console.ReadLine());

                Console.Write("Qual é o valor de cada peça que o vendedor {0} vendeu? ", i);
                precoCadaPeca[i] = float.Parse(Console.ReadLine());
            }

            for(int i = 0; i < quantidadePecasVendidas.Length; i++)
            {
                totalPecas += quantidadePecasVendidas[i];
            }

            for(int i = 0; i < 10; i++)
            {
                totalVenda[i] = quantidadePecasVendidas[i] * precoCadaPeca[i];
            }

            Console.Clear();

            Console.WriteLine("Foi vendido um total de {0} peças.", totalPecas);

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(" O vendedor {0} faturou um total de R$ {1}", i, totalVenda[i]);
            }
        }

        static void Exercicio6()
        {
            int linha = 3, coluna = 2;
            float contadorPar = 0, mediaTotal = 0, somaImpar = 0;
            float[,] matriz = new float[linha,coluna];

            for (int i = 0; i < linha; i++)
			{
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write("Informe o elemento ({0},{1}) ", i, j);
                    matriz[i, j] = float.Parse(Console.ReadLine());

                    if (matriz[i,j] % 2 == 0)
                    {
                        contadorPar++;
                    }

                    else
                    {
                        somaImpar += matriz[i,j];
                    }
                    mediaTotal += matriz[i,j];
                    mediaTotal = mediaTotal / 12;
                }
			}
            Console.Clear();
            Console.Write("{0} números são Pares, {1} é a soma de todos os números impares e {2} é a média de todos os valores.", contadorPar, somaImpar, mediaTotal);
        }

        static void Exercicio7() 
        {
            int linha = 7, coluna = 7;
            float maior = 0, menor = 0;
            float[,] matriz = new float[linha,coluna];
            float[] maiorLinha = new float[linha];
            float[] menorColuna = new float[coluna];

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write("Informe o elemento ({0},{1}) ", i, j);
                    matriz[i, j] = float.Parse(Console.ReadLine());
                }
            }

            maior = matriz[0,0];

            for (int i = 0; i < linha; i++)
            {
                maior = matriz[i,0];
                for (int j = 0; j < coluna; j++)
                {
                    if (matriz[i,j] > maior)
                    {
                        maior = matriz[i,j];
                    }
                }
                maiorLinha[i] = maior;
            }

            menor = matriz[0,0];

            for (int j = 0; j < coluna; j++)
            {
                for (int i = 0; i < linha; i++)
                {
                    if (matriz[i,j] < menor)
                    {
                        menor = matriz[i,j];
                    }
                }
                menorColuna[j] = menor;
                menor = maiorLinha[j];
            }

            Console.Clear();
            Console.WriteLine("A matriz digitada foi: ");

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write("\t" + matriz[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("O maior elemento de cada linha foi: ");
            for (int i = 0; i < linha; i++)
            {
                Console.Write("\t" + maiorLinha[i]);
            }

            Console.WriteLine();

            Console.WriteLine("O menor elemento de cada coluna foi: ");
            for (int i = 0; i < coluna; i++)
            {
                Console.Write("\t" + menorColuna[i]);
            }

        }

        static void Exercicio8()
        {
            /* Faça um programa C# que receba a idade, o peso e a altura de cada um dos jogadores dos cinco times que estão competindo um campeonato de futebol (cada time possui onze jogadores), calcule e mostre:
            
            * a quantidade de jogadores com idade inferior a 18 anos;
            * a média das idades dos jogadores de cada time;
            * a média das alturas de todos os jogadores do campeonato;
            * a porcentagem de jogadores com mais de 80 quilos entre todos os jogadores do campeonato. */

            int idade = 0;
            float peso = 0, altura = 0;
            float mediaIdadesCadaTimes = 0, porcentagem80quilos, somaAlturas = 0, mediaAlturasTotal = 0;
            int quantidadeJogadoresPorTime = 2, quantidadeTimes = 1, jogadoresTotais = 2, mais80quilos = 0, somaIdades = 0, quantidadeMenor18 = 0;

            for (int i = 0; i < quantidadeTimes; i++)
            {
                somaIdades = 0;
                Console.WriteLine("TIME {0}", i);
                
                for (int j = 0; j < quantidadeJogadoresPorTime; j++)
                {
                    Console.Write("Qual é a idade do jogador {0}: ", j);
                    idade = int.Parse(Console.ReadLine());

                    Console.Write("Qual é a altura do jogador {0}: ", j);
                    altura = float.Parse(Console.ReadLine());

                    Console.Write("Qual é o peso do jogador {0}: ", j);
                    peso = float.Parse(Console.ReadLine());

                    Console.WriteLine();

                    if (idade < 18)
                    {
                        quantidadeMenor18++;
                    }

                    if (peso > 80)
                    {
                        mais80quilos++;
                    }

                    somaAlturas += altura;
                    somaIdades += idade;

                    mediaIdadesCadaTimes = somaIdades / quantidadeJogadoresPorTime;
                }
                mediaIdadesCadaTimes = somaIdades / quantidadeJogadoresPorTime;
                Console.WriteLine("A média das idades do time {0} é {1}", i, mediaIdadesCadaTimes);
            }
            mediaAlturasTotal = somaAlturas / jogadoresTotais;
            porcentagem80quilos = mais80quilos * 100 / jogadoresTotais;

            Console.WriteLine("A quantidade de jogadores com menos de 18 anos é {0}", quantidadeMenor18);

            Console.WriteLine("A média das alturas de todos os jogadores do campeonato é {0}", mediaAlturasTotal);

            Console.WriteLine("A porcentagem de jogadores com mais de 80 quilos entre todos os jogadores do campeonato é {0}%", porcentagem80quilos);

            Console.WriteLine();
        }

        static void Exercicio9()
        {
        /* Atividade Avaliativa - Exercício 9
        * Elabore um programa C# que carregue uma matriz 10 x 20 com números inteiros e 
        * some cada uma das linhas, armazenando o resultado das somas em um vetor. 
        * A seguir, multiplique cada elemento da matriz pela soma da linha e mostre 
        * a matriz resultante.*/

        int numeroLinhas = 3, numeroColunas = 3, soma;

        int[,] matriz = new int[numeroLinhas, numeroColunas];
        int[] somaLinhas = new int[numeroLinhas];
        int[,] resultanteMatriz = new int[numeroLinhas, numeroColunas];

        for (int i = 0; i < numeroLinhas; i++)
        {
        soma = 0;
            for (int j = 0; j < numeroColunas; j++)
            {
                Console.Write("Informe o elemento ({0},{1}) ", i, j);
                matriz[i, j] = int.Parse(Console.ReadLine());
                soma += matriz[i,j];
            }
            somaLinhas[i] = soma;
        }

            Console.WriteLine("A soma de cada linha é igual a: ");
            for (int i = 0; i < numeroLinhas; i++)
            {
                Console.Write("\t" + somaLinhas[i]);
            }

            Console.WriteLine("A matriz resultante da multiplicação da soma das linhas por cada valor: ");
            for (int i = 0; i < numeroLinhas; i++)
            {
                for (int j = 0; j < numeroColunas; j++)
                    {
                        resultanteMatriz[i,j] = somaLinhas[i] * matriz[i,j];
                        Console.Write("\t" + resultanteMatriz[i,j]);
                    }
                    Console.WriteLine();
            }
        }

        static void Exercicio10()
        {
/* Na teoria dos sistemas, define-se o elemento MINMAX de uma matriz como sendo o maior elemento da linha onde se encontra o menor elemento da matriz. Faça um programa C# que carregue uma matriz 4 x 7 com números reais, calcule e mostre o seu MINMAX e sua posição (linha e coluna).*/

        int numeroLinhas = 4, numeroColunas = 7, linha, coluna;
        float menor, minMax;
        float[,] matriz = new float[numeroLinhas, numeroColunas];

        for (int i = 0; i < numeroLinhas; i++)
        {
            for (int j = 0; j < numeroColunas; j++)
            {
                Console.Write("Informe o elemento ({0},{1}) ", i, j);
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
        menor = matriz[0,0];
        linha = 0;
        for (int i = 0; i < numeroLinhas; i++)
        {
            for (int j = 0; j < numeroColunas; j++)
            {
                if (matriz[i,j] < menor)
                {
                    menor = matriz[i,j];
                    linha = i;
                }
            }
        }
        minMax = matriz[linha,0];
        coluna = 0;
        for (int j = 0; j < numeroColunas; j++)
        {
            if (matriz[linha,j] > minMax)
            {
                minMax = matriz[linha,j];
                coluna = j;
            }
        }
        Console.WriteLine();
        Console.Write("O valor do MINMAX é {0}, e sua posição é ({1},{2})", minMax, linha, coluna);
        }
    }
}