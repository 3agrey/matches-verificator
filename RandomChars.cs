using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Function
{
    public class RandomChars
    {

        public static string Generate(int length)
        {
            Random rnd = new Random();
            char tempchar;
            string result = ("");
            StringBuilder res = new StringBuilder("");
            for (int ctr = 0; ctr <= length; ctr++)
            {
                tempchar = (Convert.ToChar(rnd.Next(65, 91)));
                res.Append(tempchar);
                result = res.ToString();
            }
            return result;
        }
    }
}