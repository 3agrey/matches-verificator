using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneratePassword
{
    public class RandomPassword
    {
        public static int length = 10;

        public static string Generate(int length)
        {
            Random rnd = new Random();
            char tempchar;
            StringBuilder res = new StringBuilder("");
            for (int ctr = 0; ctr <= length; ctr++)
            {
                tempchar = (Convert.ToChar(rnd.Next(65, 91)));
                res.Append(tempchar);
                
            }
            return res.ToString ();
        }
        static void Main(string[] args)
        {}
    }
}
