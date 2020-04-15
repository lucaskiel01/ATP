/*
* Nome: Lucas Lana Vieira Almeida
* Data: 16/04/2020
*
* Lista 1 - Exercício 14
* Descrição: Faça um programa que imprima os números ímpares entre 250 e 650 (inclusive) em ordem decrescente.
*/
using System;

namespace ativ14
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int impares = 649; impares >= 250 ; impares -= 2)
            {
                Console.Write(impares + " ");
            }
            
        }
    }
}
