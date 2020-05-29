/*
* Nome: Lucas Lana Vieira Almeida
* Data: 31/05/2020
*
* Lista 4 - Exercício 2
* Descrição: Calcular se um número é divisivel pelo outro.
*/
using System;

namespace LISTAATP4ativ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            do
            {
                Console.WriteLine("Digite dois valores para checar se o primeiro é divisível pelo segundo:");
                Console.WriteLine("Digite o primeiro:");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo:");
                num2 = int.Parse(Console.ReadLine());
                if (num1 == 0 && num2 == 0)
                {
                    break;
                }
                Console.WriteLine(Divisivel(num1, num2));
            } while (num1 != 0 && num2 != 0);

            Console.WriteLine("Fechando. Obrigado!");
        }

        public static string Divisivel(int num1, int num2)
        {
            string resp;
            if((num1 % num2) == 0)
            {
                resp = (num1 + " é divisível por " + num2);
            }
            else
            {
                resp = (num1 + " não é divisível por " + num2);
            }

            return(resp);
        }
    }

}
