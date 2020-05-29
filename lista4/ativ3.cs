/*
* Nome: Lucas Lana Vieira Almeida
* Data: 31/05/2020
*
* Lista 4 - Exercício 3
* Descrição: Apresenta o preço do item consultado.
*/
using System;

namespace LISTAATPativ3
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] tabela = new float[4, 2];
            tabela[0, 0] = 100;
            tabela[1, 0] = 101;
            tabela[2, 0] = 102;
            tabela[3, 0] = 103;
            tabela[0, 1] = 1.20f;
            tabela[1, 1] = 1.50f;
            tabela[2, 1] = 2.50f;
            tabela[3, 1] = 2.75f;

            Console.WriteLine("Digite o codigo a ser consultado:");
            int codigo = int.Parse(Console.ReadLine());
            float preco = Consulta(codigo, tabela);
            int quantidade = 1;
            if (preco == 0)
            {
                Console.WriteLine("Não existe um produto com tal código cadastrado.");
            }
            else{
                Console.WriteLine("Digite o numero de produtos sendo comprados:");
                quantidade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("O preço total é: " + (quantidade * preco));
        }

        public static float Consulta(int codigo, float[,] tabela)
        {
            float resp = 0;
            for(int i = 0; i <= 3; i++)
            {
                if (tabela[i, 0] == codigo)
                {
                    resp = tabela[i, 1];
                }
            }
            return resp;
        }

    }


}
