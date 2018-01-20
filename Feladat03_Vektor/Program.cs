using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat03_Vektor
{
    class Program
    {
        public static void  fibonacchiTombFeltotles(ref int[] tomb)
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



        static void Main(string[] args)
        {
            int[] fibTomb = new int[50];
            fibonacchiTombFeltotles(ref fibTomb);
        }
    }
}
