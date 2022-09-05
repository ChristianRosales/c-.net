using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena = "anita";
            bool bandera = true;
            for (int i = 0; i < cadena.Length; i++)
            {
                for (int j = (cadena.Length - 1); j >= 0; j--)
                {
                    if(cadena.Substring(i, 1) != cadena.Substring(j, 1))
                    {
                        bandera = false;
                    }
                }
                if(bandera)
                Console.WriteLine("Es palindromo");
                else
                Console.Write("{0}", cadena.Substring(i, 1));
            }
            Console.ReadKey();
        }
    }
}
