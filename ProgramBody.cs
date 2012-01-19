using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Body
    {
        public class Start 
        {
            static void Main()
            {
                int z = 0;
                bool b = false;
                int length = 10;
                Random rnd = new Random();
                int temp;
                String test;
                string a = ("ABCDEFGHIJKLMNOPQESTUVWXYZ");
                int lengthchars = 25;
                for (int ctr = 0; ctr < length; ctr++)
                {
                    temp = rnd.Next(0, 20);
                    test = Function.RandomChars.Generate(temp);
                    Console.WriteLine(test.Length == temp);
                }
                for (int ctr = 0; ctr < 100; ctr++)
                {
                    test = Function.RandomChars.Generate(length);
                    for (int c = 0; c <= lengthchars; c++)
                    {
                        if (String.Compare(test, z, a, c, 1) != 0)
                        {
                            b = true;
                        }
                    }
                    Console.WriteLine(b);
                }
                for (int ctr = 0; ctr < length; ctr++)
                {
                    test = Function.RandomChars.Generate(length);
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}