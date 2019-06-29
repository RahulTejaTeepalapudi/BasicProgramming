using System;


namespace e_maze_in
{
    /// <summary>
    /// Input consists of a single line with upper case letters L,R,D,U denoting the directions.
    /// Consider a 2D plane, starting from origin, based on those directions print the final coordinates.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            char[] code = Console.ReadLine().ToCharArray();
            for (int i = 0; i < code.Length; i++)
            {
                switch (code[i])
                {
                    case 'L':
                        x += -1;
                        break;
                    case 'R':
                        x += 1;
                        break;
                    case 'D':
                        y += -1;
                        break;
                    default:
                        y += 1;
                        break;
                }
            }
            Console.WriteLine("{0} {1}", x, y);
            Console.ReadLine(); 
        }
    }
}
