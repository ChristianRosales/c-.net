using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 1;
            int C = 0;
            while (C <= 5)
            {

                A = B;
                B = C;
                C = A + B;
                Console.Write(" " + C + " ");
            }
            Console.ReadKey();
        }
    }
}
