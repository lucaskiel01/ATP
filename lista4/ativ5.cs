/*
* Nome: Lucas Lana Vieira Almeida
* Data: 31/05/2020
*
* Lista 4 - Exercício 5
* Descrição: Calcular área ou perímetro
*/
using System;

namespace LISTAATPativ5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 se deseja calcular a área do círculo e 2 se deseja calcular o perímetro");
            int menu = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o raio do círculo:");
            float raio = float.Parse(Console.ReadLine());

            if (menu == 1)
            {
                Console.WriteLine(Area(raio));
            }
            else if (menu == 2)
            {
                Console.WriteLine(Perimetro(raio));
            }
            else
            {
                Console.WriteLine("Não há operação representada pelo numero digitado.");
            }
        }

        public static float Area(float raio)
        {
            return(3.14f * raio * raio);
        }


        public static float Perimetro(float raio)
        {
            return (3.14f * 2 * raio);
        }
    }
}
