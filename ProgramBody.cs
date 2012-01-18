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
                String test1 = Function.RandomChars.Generate(0);
                String test2 = Function.RandomChars.Generate(1);
                String test3 = Function.RandomChars.Generate(15);
                Console.WriteLine(test1.Length == 0);
                Console.WriteLine(test2.Length == 1);
                Console.WriteLine(test3.Length == 15);
                Console.ReadKey();
            }
        }
    }
}