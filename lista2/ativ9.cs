/*
* Nome: Lucas Lana Vieira Almeida
* Data: 16/04/2020
*
* Lista 1 - Exercício 9
* Descrição: Construa um programa que calcule e escreva quantos anos serão necessários para que
Bernardo seja maior que André.
*/
using System;

namespace ativ9
{
    class Program
    {
        static void Main(string[] args)
        {
            int andre = 150;
            int bernardo = 110;
            int anos = 0;

            while (andre >= bernardo)
            {
                andre+= 2;
                bernardo += 3;
                anos++;
            }

            Console.WriteLine("Irá demorar " + anos + " anos para Bernardo superar André em tamanho.");
        }
    }
}
