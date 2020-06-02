/* Aluno: Lucas Lana Vieira Almeida
Data: 02/06/2020
Prova 2
Atividade 2
*/
using System;

namespace Prova2ATPativ2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            do
            {
                Console.WriteLine("Digite um numero N: (maior ou igual a 3)");
                n = int.Parse(Console.ReadLine());

            } while (n < 3); //checa o valor de n

            int[,] matriz = new int[n, n];
            //Console.WriteLine("Digite os valores da matriz da esquerda pra direita, de cima pra baixo.");

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++){
                    Console.WriteLine("Digite o valor da posição [" + i + "][" + j + "]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Matriz digitada: ");
            for (int i = 0; i < n; i++) //escreve a matriz
            {
                Console.WriteLine(); //separa as linhas
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
            }
            Console.WriteLine();
            int[] resp = MaioresMedia(matriz, n);

            Console.WriteLine("Os elementos nas seguintes posições são menores que a média:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(matriz[i,j] < resp[1])
                    Console.Write("[" + i + "][" + j + "], ");
                }
            }
            Console.WriteLine("Maior valor: " + resp[0] + " / Média: " + resp[1]);


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j)
                     matriz[i, j] = resp[1];
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
            }

        }

        public static int[] MaioresMedia(int[,] matriz, int n)
        {
            //para pegar o maior valor
            int[] resp = new int[2];
            int maior = matriz[0,0]; //inicializar com um elemento da nossa matriz para não correr riscos
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] > maior){
                        maior = matriz[i, j];
                    }
                }

            }//fim for

            int media = 0;

            for (int j = 0; j < n; j++)
            {
                    media += matriz[1, j];
            }

            for (int j = 0; j < n; j++)
            {
                media += matriz[2, j];
            }

            media = (media / (n * 2));
            resp[0] = maior;
            resp[1] = media;
            return resp;
        }
    }
}
