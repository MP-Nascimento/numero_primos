using System;

namespace numeros_primos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int max = 100;

            for(int i = 0; i < max; i++)
            {
                if (i == 2) Console.WriteLine(i);

                else
                {
                    if (i % 2 == 0) continue;

                    else
                    {
                        bool ePrimo = true;

                        for (int j = 3; j < i / 2; j++)

                        {
                            if (i % j == 0)
                            {
                                ePrimo = false;
                                break;
                            }

                        }

                        if (ePrimo) Console.WriteLine(i);
                    }   

                }
                
            }


        }
    }
}
