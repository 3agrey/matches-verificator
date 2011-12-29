using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {}
            static string getrandom(int length)        
    {          
            string Chars = "qwertyuiopasdfghjklzxcvbnm";
            string RESULT = "";

            for (int j = 0; j <= length-1; j++)
            {System.Random number = new System.Random((int)DateTime.Now.Ticks);
             int rnd = number.Next(25);
             RESULT += Convert.ToChar(Chars[rnd]);}

            return RESULT;


        }
    } 
}
