using System;

namespace Ladderophilia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i <= n; i++)
            {
                while (count <= 2)
                {
                    if (count == 0 || count == 1)
                    {
                        Console.WriteLine("*   *");
                    }
                    if (count == 2 && i != n)
                    {
                        Console.WriteLine("*****");
                    }
                    count++;
                }
                count = 0;
            }
            Console.ReadLine();
        }
    }
}
