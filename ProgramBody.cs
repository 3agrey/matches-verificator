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
                bool b = false;
                int length = 10;
                Random rnd = new Random();
                int temp;
                String test;
                string a = ("ABCDEFGHIJKLMNOPQESTUVWXYZ");
                int lengthchars = 25;
                Console.WriteLine(0);
                Console.WriteLine(Function.RandomChars.Generate(0).Length == 0);
                Console.WriteLine(1);
                Console.WriteLine(Function.RandomChars.Generate(1).Length == 1);
                Console.WriteLine(15);
                Console.WriteLine(Function.RandomChars.Generate(15).Length == 15);
                Console.WriteLine(1024);
                Console.WriteLine(Function.RandomChars.Generate(1024).Length == 1024);
                Console.WriteLine(-1);
                Console.WriteLine(Function.RandomChars.Generate(-1).Length == -1);
                for (int ctr = 0; ctr < length; ctr++)
                {
                    temp = rnd.Next(-10, -2);
                    Console.WriteLine(temp);
                    test = Function.RandomChars.Generate(temp);
                    Console.WriteLine(test.Length == temp);
                }
                for (int ctr = 0; ctr < length; ctr++)
                {
                    test = Function.RandomChars.Generate(length);
                    for (int z = 0; z < length; z++)
                    {
                        for (int c = 0; c < lengthchars; c++)
                        {
                            if (String.Compare(test, z, a, c, 1) == 0)
                            {
                                b = true;
                            }
                        }
                    }
                    Console.WriteLine(b);
                }
                for (int ctr = 0; ctr < length; ctr++)
                {

                }
                Console.ReadKey();
            }
        }
    }
}