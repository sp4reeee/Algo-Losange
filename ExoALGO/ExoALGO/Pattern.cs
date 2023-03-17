using System;

namespace ExoALGO
{
    internal class Pattern
    {
        public static void pattern()
        {
            /*
             desired output :
                  *
                 ***
                *****
                 ***
                  *
             */

            int count = 5;
            int middle = count / 2 + 1;

            for (int i = 0; i < count; i++)
            {
                if (i < middle)
                {
                    space(middle - i - 1);
                    print(i * 2 + 1);
                }
                else
                {
                    space(i - middle + 1);
                    print((count - i) * 2 - 1);
                }
                Console.Write("\n");
            }

            static void space(int y)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write(" ");
                }
            }


            static void print(int z)
            {
                for (int i = 0; i < z; i++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}