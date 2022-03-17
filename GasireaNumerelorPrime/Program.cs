using System;

namespace GasireaNumerelorPrime
{
    class Program
    {
        public static bool IsPrim (int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;               
            }
            return true;   //true ->nr e prim, false-> nr nu este prim
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');

            int[] v = new int[n];
          

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                if (IsPrim(v[i]))
                    Console.Write(v[i] + " ");
               
            }

            /*for (int i = 0; i < n; i++)
            {
                Console.WriteLine(v[i]); 

            }*/
            


            Console.ReadKey();
        }
    }
}
