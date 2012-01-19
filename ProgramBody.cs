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
                for (int ctr = 0; ctr < length; ctr++)
                {
                    temp = rnd.Next(0, 20);
                    test = Function.RandomChars.Generate(temp);
                    Console.WriteLine(test.Length == temp);
                }
                for (int ctr = 0; ctr < 100; ctr++)
                {
                    test = Function.RandomChars.Generate(length);

                    Console.WriteLine(String.Compare(test, 1, a, 1, 1));
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