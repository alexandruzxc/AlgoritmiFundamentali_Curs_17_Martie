using System;

namespace NumereleCareAuPrimaCifraPrima
{
    class Program
    {
        public static bool CifraEgala(int n)
        {
            int pc = n % 10;
            while (n >= 10)
                n = n / 10;
            if (pc == n)
                return true;
                return false; 

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] data = Console.ReadLine().Split(' ');

            int[] v = new int[n];


            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(data[i]);
                if (CifraEgala(v[i]))
                    Console.Write(v[i] + " ");

            }

        }
    }
}
