/*
* Nome: Lucas Lana Vieira Almeida
* Data: 16/04/2020
*
* Lista 1 - Exercício 4
* Descrição: Desenvolva um programa para apresentar o menu de um jogo com 4 opções.
*/
using System;

namespace ativ4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            while (condition == true)
            {

                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("a. Jogar");
                Console.WriteLine("b. Seleção de personagem");
                Console.WriteLine("c. Configurações");
                Console.WriteLine("d. Sair");
                Console.WriteLine();

                char entrada = char.Parse(Console.ReadLine());


                switch (entrada)
                {
                    case 'a':
                        Console.WriteLine("Jogar");
                        Console.WriteLine();
                        break;
                    case 'b':
                        Console.WriteLine("Seleção de Personagens");
                        Console.WriteLine();
                        break;
                    case 'c':
                        Console.WriteLine("Configurações");
                        Console.WriteLine();
                        break;
                    case 'd':
                        Console.WriteLine("Saindo.");
                        condition = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Console.WriteLine();
                        break;
                }
            }

        }
    }
}
