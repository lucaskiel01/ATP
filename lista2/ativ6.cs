/*
* Nome: Lucas Lana Vieira Almeida
* Data: 16/04/2020
*
* Lista 1 - Exercício 6
* Descrição: Faça um programa que leia um número inteiro positivo n e escreva todos os números positivos múltiplos de
3, de 0 até n.
*/
using System;

namespace ativ6
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplos = 0;

            Console.WriteLine("Escreva um número inteiro positivo:");
            int numero = int.Parse(Console.ReadLine());

            while ((multiplos < numero - 3))
            {
                multiplos+= 3;
                Console.Write(multiplos + " ");
            }
        }

    }
}
