using System;

namespace Duration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int[] N = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
                int d = (N[2] * 60 + N[3]) - (N[0] * 60 + N[1]);
                Console.WriteLine(d);
                n--;
            }
        }
    }
}
