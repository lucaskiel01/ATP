/*
* Nome: Lucas Lana Vieira Almeida
* Data: 31/05/2020
*
* Lista 4 - Exercício 6
* Descrição: Método que encontre o menor número inteiro e positivo N que satisfaça, simultaneamente, às
relações
*/
using System;

namespace LISTAATPativ6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O menor número inteiro que satisfaz as condições é " + Numero());    
        }

        public static int Numero()
        {
            bool test = false;
            int n = 0;
            do
            {
                n++;
                if((n % 3 == 2) && (n % 5 == 3) && (n % 7 == 4))
                {
                    test = true;
                }
                
               
            } while (test == false);

            return n;
        }
    }
}
