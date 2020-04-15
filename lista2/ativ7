/*
* Nome: Lucas Lana Vieira Almeida
* Data: 16/04/2020
*
* Lista 1 - Exercício 7
* Descrição: Desenvolva um programa que leia 4 números, por meio do teclado, e determine e imprima a soma dos três
menores.
*/
using System;

namespace ativ7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];

            Console.WriteLine("Digite o primeiro número: ");
            numeros[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            numeros[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            numeros[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto número: ");
            numeros[3] = int.Parse(Console.ReadLine());

            Array.Sort(numeros);

            Console.WriteLine((numeros[0] + numeros[1] + numeros[2]));
        }
    }
}
