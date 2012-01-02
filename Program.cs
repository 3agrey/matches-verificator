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
        static string GetRandom(int length)
        {
            Random rnd = new Random();
            StringBuilder res = new StringBuilder("");
            for (int ctr = 0; ctr <= length; ctr++)
            {
                res.Append(Convert.ToChar(rnd.Next(65, 91)));
            }
            return res;
        }
    } 
}
