using System;

namespace BookOfPotionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int l = s.Length;
            if (l < 10)
                PrintResult("Illegal ISBN");
            else
            {
                int sum = 0;
                for (int i = 0; i < l; i++)
                    sum += (i + 1) * (int)char.GetNumericValue(s[i]);

                if (sum % 11 == 0)
                    PrintResult("Legal ISBN");
                else
                    PrintResult("Illegal ISBN");
            }
            Console.ReadLine();
        }

        static void PrintResult(string s)
        {
            Console.WriteLine(s);
        }
    }
}
