using System;

namespace ativ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos = 0;
            float popA = 90500000;
            float popB = 199500000;
            
            while (popB > popA)
            {
                popA = (popA * 1.03f);
                popB = (popB * 1.015f);
                anos++;
            }

            Console.WriteLine("O número de anos necessários para que a população do país A ultrapasse ou iguale a população do país B é: " + anos);

        }
    }
}
