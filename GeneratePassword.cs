using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneratePassword
{
    public class RandomPassword
    {
        int length = 10;

        public static string Generate(int length)
        {
            Random rnd = new Random();
            char[] res = null;
            for (int ctr = 0; ctr <= length; ctr++)
            {
                res= new char[rnd.Next(65,91)];
            }
            return new string(res);
        }
    }
}
