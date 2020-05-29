/*
* Nome: Lucas Lana Vieira Almeida
* Data: 31/05/2020
*
* Lista 4 - Exercício 8
* Descrição: Faça um programa que leia dois valores e chame um método que recebe estes 2 valores de entrada e que
retorna o maior valor no primeiro parâmetro e o menor valor no segundo parâmetro.
*/
using System;

namespace LISTAATPativ8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Os numeros digitados foram " + num1 + " e " + num2 + ".");
            Console.WriteLine();
            Console.WriteLine("O maior número é: " + DefineMaior(num1, num2));

        }

        public static int DefineMaior(int num1, int num2)
        {
            int resp;
            if (num1 > num2) {
                resp = num1;
            }
            else
            {
                resp = num2;
            }
            return (resp);
        }
    }
}
