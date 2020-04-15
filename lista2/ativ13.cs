/*
* Nome: Lucas Lana Vieira Almeida
* Data: 16/04/2020
*
* Lista 1 - Exercício 13
* Descrição: Faça um programa que realize o produto entre 2 números inteiros A e B utilizando somas sucessivas. Os números
deverão ser lidos do teclado.
*/
using System;

namespace ativ13
{
    class Program
    {
        static void Main(string[] args)
        {
            int produto = 0;
            Console.WriteLine("Digite o primeiro numero:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            int numero2 = int.Parse(Console.ReadLine());

            while(numero2 > 0)
            {
                produto+= numero1 ;
                numero2--;
            }

            Console.WriteLine("O produto é: " + produto);
        }
    }
}
