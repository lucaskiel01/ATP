/*
* Nome: Lucas Lana Vieira Almeida
* Data: 16/04/2020
*
* Lista 1 - Exercício 10
* Descrição: O algoritmo deve calcular e apresentar na tela o número de alunos que têm idade superior a 18 anos e a média de idade da turma.
*/
using System;

namespace ativ10
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            float numAlunos = -1; //inicializando com -1 por causa da flag, que adiciona um no contador
            float somaIdades = 0;
            int deMaior = 0;

            do
            {
                Console.WriteLine("Escreva a idade do aluno (digite 0 para finalizar)");

                numAlunos++;
                idade = int.Parse(Console.ReadLine());
                somaIdades += idade;

                if (idade > 18)
                {
                    deMaior++;
                }

            }while(idade != 0);

            float media = (somaIdades / numAlunos);

            Console.WriteLine("O numero de alunos com idade superior a 18 anos é: " + deMaior);
            Console.WriteLine("A média da idade dos alunos é: " + media);
        }
    }
}
