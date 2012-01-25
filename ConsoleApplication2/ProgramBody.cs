using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ppc.GeneratePassword
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args == null || args.Length != 1)
            {
                Console.WriteLine("typical usage: generatepwd.exe 13");
                return;
            }
            int passwordLength = int.Parse(args[0]);
            string result = RandomChars.Generate(passwordLength);
            Console.WriteLine(result);

            //todo: remove all this rubbish; use unit tests instead
            /*
                   
            for (int ctr = 0; ctr < length; ctr++)
            {
                temp = rnd.Next(-10, -2);
                Console.WriteLine(temp);
                test = Function.RandomChars.Generate(temp);
                Console.WriteLine(test.Length == temp);
            }
            for (int ctr = 0; ctr < length; ctr++)
            {
                test = Function.RandomChars.Generate(length);
                Console.WriteLine(test);
                for (int z = 0; z < length; z++)
                {
                    for (int c = 0; c < lengthchars; c++)
                    {
                        if (String.Compare(test, z, a, c, 1) == 0)
                        {
                            b = true;
                        }
                    }
                }
                Console.WriteLine(b);
            }
            Console.ReadKey();
            */
        }
    }
}