using System;
using System.Collections.Generic;


namespace StringAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] A;
            char[] B;
            IDictionary<char, int> dictA;
            IDictionary<char, int> dictB;
            int sum;
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                sum = 0;
                A = Console.ReadLine().ToCharArray();
                B = Console.ReadLine().ToCharArray();
                dictA = new Dictionary<char, int>();
                dictB = new Dictionary<char, int>();

                /* Form Dictionary from string 1 */
                for (int i = 0; i < A.Length; i++)
                {
                    if (!dictA.ContainsKey(A[i]))
                    {
                        dictA.Add(A[i], 1);
                    }
                    else
                    {
                        dictA[A[i]]++;
                    }
                }

                /* Form Dictionary from String 2 */
                for (int j = 0; j < B.Length; j++)
                {
                    if (!dictB.ContainsKey(B[j]))
                    {
                        dictB.Add(B[j], 1);
                    }
                    else
                    {
                        dictB[B[j]]++;
                    }
                }

                
                foreach (KeyValuePair<char, int> pair in dictA)
                {
                    if (dictB.ContainsKey(pair.Key))
                    {
                        sum += Math.Abs(pair.Value - dictB[pair.Key]);
                    }
                    else
                    {
                        sum += pair.Value;
                    }
                }

                foreach (KeyValuePair<char, int> pair in dictB)
                {
                    if (!dictA.ContainsKey(pair.Key))
                    {
                        sum += pair.Value;
                    }
                }

                Console.WriteLine(sum);
                Console.ReadLine();
                t--;
            }
        }
    }
}
