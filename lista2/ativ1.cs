            float s = 0;
            int numerador = 1;
            bool soma = true;

            Console.WriteLine("Digite o valor de n: ");
            float n = float.Parse(Console.ReadLine());
            
            while (n > 0)
            {
                if(soma == true) //entra aqui pra somar
                {
                    s += (numerador/n);
                    n--;
                    numerador++;
                    soma = false;
                }

                else //entra aqui pra subtrair
                {
                    s -= (numerador/n);
                    n--;
                    numerador++;
                    soma = true;
                }

            }

            Console.WriteLine("O valor de S é: " + s);
