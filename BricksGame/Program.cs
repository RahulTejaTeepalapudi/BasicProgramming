using System;


namespace BricksGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int bricks = int.Parse(Console.ReadLine());
            int r = 1;
            while (bricks > (r + (r * 2)))
            {
                bricks = bricks - (r + (r * 2));
                r++;
            }
            if (bricks <= r)
            {
                Console.WriteLine("Patlu");
            }
            else
            {
                Console.WriteLine("Motu");
            }
            Console.ReadLine();
        }
    }
}
