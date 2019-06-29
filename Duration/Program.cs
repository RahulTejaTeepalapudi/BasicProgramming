using System;

namespace Duration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                string[] array = input.Split(' ');

                int sh = int.Parse(array[0]);
                int sm = int.Parse(array[1]);
                int eh = int.Parse(array[2]);
                int em = int.Parse(array[3]);

                TimeSpan start = new TimeSpan(sh, sm, 0);
                TimeSpan end = new TimeSpan(eh, em, 0);

                TimeSpan diff = end.Subtract(start);

                Console.WriteLine(diff.Hours + " " + diff.Minutes);

            }
        }
    }
}
