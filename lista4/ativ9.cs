/*
* Nome: Lucas Lana Vieira Almeida
* Data: 31/05/2020
*
* Lista 4 - Exercício 9
* Descrição: Converte graus Celsius para Fahrenheit.
*/
using System;

namespace LISTAATPativ9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em graus celsius:");
            float celsius = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(celsius + " graus Celsius, são " + ParaFahrenheit(celsius) + " graus Farenheit.");
        }

        public static float ParaFahrenheit(float celsius)
        {
            return (((9 * celsius) + 160) / 5);
        }
    }
}
