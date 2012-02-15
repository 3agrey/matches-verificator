using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ppc.GeneratePassword
{
    public class RandomCharsGenerator
    {
        public RandomCharsGenerator(int length)
        {
            Random rnd = new Random();
            StringBuilder res = new StringBuilder();


            for (int i = 0; i < length; i++)
            {
                char tempchar = (Convert.ToChar(rnd.Next(97, 122)));
                res.Append(tempchar);
            }
            string result = res.ToString();
        }
    }
}