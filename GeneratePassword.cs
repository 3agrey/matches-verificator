using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneratePassword
{
    public class RandomPassword
    {
       
        public static string Generate(int length,ref string result)
        {
            Random rnd = new Random();
            char tempchar;
            StringBuilder res = new StringBuilder("");
            for (int ctr = 0; ctr <= length; ctr++)
            {
                tempchar = (Convert.ToChar(rnd.Next(65, 91)));
                res.Append(tempchar);
                result = res.ToString();
            }
            return result;
        }
        static void Main()
        {
            string password = ("");
            Generate(10,ref password);
            System.Console.WriteLine(password);
            System.Console.ReadKey();
        }
    }
}
