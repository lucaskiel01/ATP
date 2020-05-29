/*
* Nome: Lucas Lana Vieira Almeida
* Data: 31/05/2020
*
* Lista 4 - Exercício 4
* Descrição: Quantidade de números impares entre n1 e n2.
*/
using System;

namespace LISTAATPativ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular a quantidade de números ímpares entre dois números inteiros");
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A quantidade de números ímpares entre " + n1 + " e " + n2 + " é: " + ContaImpar(n1, n2) );
        }

        public static int ContaImpar(int n1, int n2)
        {
            if (n1 > n2)
            {
                int temp = n1;
                n1 = n2;
                n2 = temp;
            }
            int impares = 0;
            
            for(int i = n1; i <= n2; i +=2)
            {
                impares++;
            }

            return impares;

        }
    }
}
