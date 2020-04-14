using System;

namespace ATP2ativ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 5 dígitos: ");
            string entrada = Console.ReadLine();
            char[] numero = new char[5];
            numero = entrada.ToCharArray();

            if ((numero[0] == numero[4]) && (numero[1] == numero[3]))
            {
                Console.WriteLine("Este numero é um palíndromo.");
            }
            else
            {
                Console.WriteLine("Este numero não é um palíndromo.");
            }
            
            
        }
    }
}
