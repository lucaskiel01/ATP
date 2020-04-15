/*
* Nome: Lucas Lana Vieira Almeida
* Data: 16/04/2020
*
* Lista 1 - Exercício 7
* Descrição: Escreva um programa que peça um número N maior que 2 e que gere e escreva os N primeiros
termos da série de Fibonacci.
*/
using System;

namespace ativ8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números da sequência Fibonacci você quer ver? (deve ser maior que 2)");
            int n = int.Parse(Console.ReadLine());

            int anterior = 1;
            int anterior2 = 1;
            int atual;

            n -= 2;

            Console.Write("1 1 ");
            while (n > 0)
            {
                atual = anterior + anterior2;
                Console.Write(atual + " ");

                anterior = anterior2;
                anterior2 = atual;
                n--;
            }
        }
    }
}
