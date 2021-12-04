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