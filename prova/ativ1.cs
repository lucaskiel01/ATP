/* Aluno: Lucas Lana Vieira Almeida
Data: 02/06/2020
Prova 2
Atividade 1
*/

using System;

namespace Prova2ATP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do lado A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado B:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado C:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado D:");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Os lados digitados foram: [" + a + "] [" + b + "] [" + c + "] [" + d + "]");
            switch (IsQuadrilatero(a, b, c, d))
            {
                case 1: 
                    Console.WriteLine("É um quadrilátero do tipo losango");
                    break;
                case 2:
                    Console.WriteLine("É um quadrilatero, do tipo paralelogramo");
                    break;
                case 3:
                    Console.WriteLine("É um quadrilatero, que não é um losango nem um paralelogramo");
                    break;
                default:
                    Console.WriteLine("Não é um quadrilátero.");
                    break;
            }


        }



        public static int IsQuadrilatero(int a, int b, int c, int d)
        {
            int resp = 3;
            if ((a > (b + c + d)) || (b > (a + c + d)) || (c > (b + a + d)) || (d > (b + c + a)))
            {
                resp = 0;
            }
            else if ((a == b) && (b == c) && (c == d))
            {
                resp = 1;
            }else if((a == c) && (b == d)){
                resp = 2; 
            }

            return resp;
        }
    }
}
