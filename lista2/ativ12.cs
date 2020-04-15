/*
* Nome: Lucas Lana Vieira Almeida
* Data: 16/04/2020
*
* Lista 1 - Exercício 12
* Descrição: Escreva um programa que leia um número N que indica quantos valores devem ser lidos a seguir. Para cada
número lido, mostre uma tabela contendo o valor lido e o fatorial deste valor.
*/
using System;

namespace ativ12ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite quantas leituras de valores deseja fazer:");
            int leituras = int.Parse(Console.ReadLine());
            int fatorial;
            
            while(leituras > 0)
            {
                Console.WriteLine("Digite o numero:");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Numero: " + numero + " | Fatorial: ");
                
                fatorial = 1;
                while(numero != 1)
                {
                    fatorial = (fatorial * numero);
                    numero--;
                }

                Console.Write(fatorial);
                Console.WriteLine();
                Console.WriteLine();

                leituras--;                
            }
        }
    }
}
