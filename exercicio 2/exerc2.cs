using System;
// O sistema de avaliação de determinada disciplina é composto por três provas. A  primeira  prova  tem  peso  2,  a  segunda  tem  peso  3  e  a  terceira  tem  peso  5. Considerando  que  a  média  para  aprovação  é  7.0.  Faça  um  programa  em  C# para  calcular  a média final  de  um  aluno desta  disciplina e  dizer  se  o  aluno  foi aprovado  ou  não.  Ao  final,  imprima  o  nome  do  aluno,  suas  notas,  a  média ponderada e uma das mensagens: Aprovado, Reprovado ou em Prova Final (a média é 7.0 para aprovação, menor que 3.0 para reprovação e as demais em prova final). 

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeAluno;

            float notaProva1;
            float notaProva2;
            float notaProva3;

            float nota1Final;
            float nota2Final;
            float nota3Final;

            float mediaFinal;

            Console.WriteLine("Qual o nome do aluno?");
                nomeAluno = Console.ReadLine();
            Console.WriteLine("Qual o valor da prova 1?");
                notaProva1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da prova 2?");
                notaProva2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da prova 3?");
                notaProva3 = float.Parse(Console.ReadLine());
            
            nota1Final = notaProva1 * 2;
            nota2Final = notaProva2 * 3;
            nota3Final = notaProva3 * 5;

            mediaFinal = (nota1Final + nota2Final + nota3Final)/10;

            if(mediaFinal >= 7) {
                Console.WriteLine("O aluno " + nomeAluno + " foi aprovado com as respectivas notas: " + nota1Final + ", " + nota2Final + ", " + nota3Final  + " e essa sua média final " + mediaFinal);
            }

            else if(mediaFinal <=3) {
                Console.WriteLine("O aluno " + nomeAluno + " foi reprovado com as respectivas notas: " + nota1Final + ", " + nota2Final + ", " + nota3Final  + " e essa sua média final " + mediaFinal);
            }
            else {
                Console.WriteLine("O aluno " + nomeAluno + " está de recuperação e terá que fazer a prova final, sendo essas suas respectivas notas: " + nota1Final + ", " + nota2Final + ", " + nota3Final + " e essa sua média final " + mediaFinal);
            }
        }
    }
}
