using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BBeguTe Ko/lu4ecTBo 6ykB:");
            string chislo = Console.ReadLine();
            int length = int.Parse(chislo);
            
            string Chars = "qwerty";
            string RESULT = "";

            for (int j = 0; j <= length-1; j++)
            {System.Random number = new System.Random((int)DateTime.Now.Ticks);
             int rnd = number.Next(4);
             RESULT += Convert.ToChar(Chars[rnd]);}

            Console.WriteLine ("{0}" , RESULT);
            Console.ReadLine ();


        }
    } 
}
