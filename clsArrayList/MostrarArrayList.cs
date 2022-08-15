using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsArrayList
{
    public class MostrarArrayList
    {
        ArrayList Lista;
        public MostrarArrayList()
        {
            Lista = new ArrayList();
        }
        public void CapturarDatos()
        {
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("Igrese un dato {0}: ", i + 1);
                string cadena = Console.ReadLine();
                Lista.Add(cadena);
            }
        }
        public void MostrarDatos()
        {
            foreach(var item in Lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
