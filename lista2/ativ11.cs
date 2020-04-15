/*
* Nome: Lucas Lana Vieira Almeida
* Data: 16/04/2020
*
* Lista 1 - Exercício 11
* Descrição: Escreva um programa que calcule quantos e quais são os números de 4 dígitos que possuem a mesma característica do número 3025.
*/
using System;

namespace ativ11
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantos = 1000;

            int primeirosDois;
            int ultimosDois;
            int temp;
            int total = 0;

            while(quantos <= 9999)
            {

                primeirosDois = (quantos / 100);
                ultimosDois = (quantos % 100);
                temp = primeirosDois + ultimosDois;
                temp = (temp * temp);

                if(temp == quantos)
                {
                    Console.WriteLine(quantos);
                    total++;
                }
                quantos++;               
            }
            Console.WriteLine("O total de números (de quatro dígitos) com essa propriedade é: " + total);
        }
    }
}
