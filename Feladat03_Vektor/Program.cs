using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat03_Vektor
{
    class Program
    {
        public static void  fibonacchiTombFeltotles(ref ulong[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                if (i== 0) { tomb[0] = 0; }
                if (i== 1) { tomb[1] = 1; }
                if (i > 1)
                {
                    tomb[i] = tomb[i - 2] + tomb[i - 1];
                }
            }
        }


        public static void fibonacchiTombKiiro(ref ulong[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("{0}. elem: {1}", i, tomb[i]);
            }
        }

        static void Main(string[] args)
        {
            ulong[] fibTomb = new ulong[50];
            fibonacchiTombFeltotles(ref fibTomb);
            fibonacchiTombKiiro(ref fibTomb);

            Console.ReadLine();
        }
    }
}
