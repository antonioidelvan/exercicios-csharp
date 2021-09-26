using System;
// Um mês antes das eleições municipais, um determinado partido político encomendou uma pesquisa de opinião sobre as intenções de votos dos eleitores. Foram entrevistas 50 pessoas que indicaram suas intenções de acordo com as seguintes opções: (A) candidato A, (B) candidato B, (C) indeciso. Desenvolva um programa em C# que faça a leitura das intenções de votos dessas 50 pessoas e que informe ao final a porcentagem de intenções para cada uma das opções existentes (candidatos A e B, e indecisos).

namespace exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            float candidatoA = 0, candidatoB = 0, candidatoC = 0, numeroVotos = 50f, i, porcentagemA, porcentagemB, porcentagemC;
            char voto;

            Console.WriteLine("Voto (A) = Candidato A; Voto (B) = Candidato (B); Voto (C) = Indeciso");
            Console.WriteLine("");

            for (i = 0; i < numeroVotos; i++)
            {

                Console.Write("Coloque seu voto: ");
                voto = char.Parse(Console.ReadLine());

                switch (voto)
                {
                    case 'A':
                        candidatoA++;
                    break;

                    case 'B':
                        candidatoB++;
                    break;

                    case 'C':
                        candidatoC++;
                    break;
                    
                    case 'a':
                        candidatoA++;
                    break;

                    case 'b':
                        candidatoB++;
                    break;

                    case 'c':
                        candidatoC++;
                    break;

                    default:
                        Console.WriteLine("Voto Nulo");
                    break;
                }
            }
            porcentagemA = (candidatoA / numeroVotos) * 100f;
            porcentagemB = (candidatoB / numeroVotos) * 100f;
            porcentagemC = (candidatoC / numeroVotos) * 100f;

            Console.WriteLine("Os candidatos A e B tiveram respectivamente " + porcentagemA + "% e " + porcentagemB + "% de votos, já votos indecisos tiveram " + porcentagemC + "%.");
        }
    }
}
