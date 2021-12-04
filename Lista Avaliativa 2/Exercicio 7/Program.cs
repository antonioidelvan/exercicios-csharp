using System;
					
public class Program
{
	public static void Main()
	{
		Exercicio7();
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
}


  