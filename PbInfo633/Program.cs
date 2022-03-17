using System;

namespace PbInfo633
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string []data = Console.ReadLine().Split(' ');
           
            int[] v = new int[n];
            int cp = 0;
            int ci = 0;

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                if (v[i] % 2 == 0)
                    cp++;
                else
                    ci++;
            }

            /*for (int i = 0; i < n; i++)
            {
                Console.WriteLine(v[i]); 

            }*/
            Console.Write((int)Math.Abs(cp - ci)); //abs ne returneaza double


            Console.ReadKey();
        }
    }
}
