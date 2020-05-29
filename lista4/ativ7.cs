/*
* Nome: Lucas Lana Vieira Almeida
* Data: 31/05/2020
*
* Lista 4 - Exercício 7
* Descrição: Método que encontre o menor número inteiro e positivo N que satisfaça, simultaneamente, às
relações
*/
using System;

namespace LISTAATPativ7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro positivo: ");
            int num = int.Parse(Console.ReadLine());
            Tabela(num);
        }

        public static void Tabela(int num)
        {
            int[] Table = new int[num];
            for(int i = 0; i < num; i++)
            {
                Table[i] = (i + 1);
                Console.Write(Table[i]);
            }
            

            int count = 1;
            while(count < num)
            {
                Console.WriteLine();
                for (int i = 0; i < num; i++)
                {
                    Table[i] = (Table[i] + 1);
                    Console.Write(Table[i]);
                }

                count++;
            }

        }
    }
}
