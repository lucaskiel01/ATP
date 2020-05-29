/*
* Nome: Lucas Lana Vieira Almeida
* Data: 31/05/2020
*
* Lista 4 - Exercício 1
* Descrição: Calcular hipotenusa de um triângulo.
*/
using System;

namespace Lista3ATP
{
    class Program
    {
        static void Main(string[] args)
        {
            int cat1;
            int cat2;
            do
            {
                cat1 = Pedir();
                cat2 = Pedir();
                if (cat1 == 0 || cat2 == 0)
                {
                    break;
                }
                    Console.WriteLine("A hipotenusa é: " + Hipotenusa(cat1, cat2));
            }  while  (cat1 != 0 || cat2 != 0);

            Console.WriteLine("Fechando. Obrigado!");
        }

        public static int Pedir()
        {

            Console.WriteLine("Digite um valor positivo (zero para fechar o programa)");
            int entrada;
            do
            {
                entrada = int.Parse(Console.ReadLine()); 
                if(entrada < 0)
                {
                    Console.WriteLine("O valor digitado deverá ser maior ou igual a zero!");
                }
                

            } while (entrada < 0);

            return entrada;
        }

        public static double Hipotenusa(int cat1, int cat2)
        {
            return(Math.Sqrt(((cat1 * cat1) + (cat2 * cat2))));
        }
    }
}
