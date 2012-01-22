using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ppc.GeneratePassword
{
    public class RandomChars
    {
        //todo: make an isntanse method, not static
        public static string Generate(int length)
        {
            Random rnd = new Random();
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                char tempchar = (Convert.ToChar(rnd.Next(97, 122)));
                res.Append(tempchar);
                //todo: do not use statements like below. ToString should be called only once.
                //result = res.ToString();
            }
            string result = res.ToString();
            return result;
        }
    }
}
