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
            int MatchesNumber = 0;

            Console.WriteLine("Enter first string length:");
            int FirstStringLength = Convert.ToInt32(Console.ReadLine());
            while (FirstStringLength <= 0)
            {
                Console.WriteLine("string length shoul be more than zero");
                FirstStringLength = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter second string length:");
            int SecondStringLength = Convert.ToInt32(Console.ReadLine());
            while (SecondStringLength <= 0)
            {
                Console.WriteLine("string length shoul be more than zero");
                SecondStringLength = Convert.ToInt32(Console.ReadLine());
            }

            string FirstString = RandomChars.Generate(FirstStringLength);
            string SecondString = RandomChars.Generate(SecondStringLength);

            for (int z = 0; z < FirstStringLength; z++)
            {
                for (int c = 0; c < SecondStringLength; c++)
                {
                    if (String.Compare(FirstString, z, SecondString, c, 1) == 0)
                    {
                        MatchesNumber++;
                    }
                }
            }
            var MatchesPersent = (MatchesNumber / (FirstStringLength + SecondStringLength));
            Console.WriteLine("Matches persent is:{0}", MatchesPersent);
            Console.ReadKey();
        }
    }
}