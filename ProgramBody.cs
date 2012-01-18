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
            static void Main(string[] args)
            {
                string password = Function.RandomChars.Generate(10);
                System.Console.WriteLine(password);
                System.Console.ReadKey();
            }
        }
    }
}