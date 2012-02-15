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
            double MatchesNumber = 0;

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

            RandomCharsGenerator FirstString = new RandomCharsGenerator(FirstStringLength);
            RandomCharsGenerator SecondString = new RandomCharsGenerator(SecondStringLength);

            for (int z = 0; z < FirstStringLength; z++)
            {
                for (int c = 0; c < SecondStringLength; c++)
                {
                    if (String.Compare(Convert.ToString(FirstString), z, Convert.ToString(SecondString), c, 1) == 0)
                    {
                        MatchesNumber++;
                    }
                }
            }

            double MatchesPersent = (MatchesNumber / (FirstStringLength + SecondStringLength));
            Console.WriteLine("Matches persent is:");
            Console.Write(MatchesPersent);
            Console.ReadKey();
        }
    }
}