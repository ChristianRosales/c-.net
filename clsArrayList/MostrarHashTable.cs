using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsArrayList
{
    public class MostrarHashTable
    {
        Hashtable Tabla;
        public MostrarHashTable()
        {
            Tabla = new Hashtable();
        }
        public void AgregarDatos()
        {
            Tabla.Add("A001", "Producto 1");
            Tabla.Add("B100", "Producto 2");
            Tabla.Add("C201", "Producto 3");
            Tabla.Add("D301", "Producto 4");
        }
        public void ImprimirDatos()
        {
            Console.WriteLine("Existen {0} elementos, dame la clave del producto: ", Tabla.Count);
            string cadena = Console.ReadLine();
            if (Tabla[cadena] == null) { Console.WriteLine("No existe"); } else
            {
                Console.WriteLine("El elemento encontrado es: ");
                Console.WriteLine(Tabla[cadena]);
            }
            Console.ReadKey();
        }
        public void EliminarElemento(string key)
        {
            Tabla.Remove(key);
        }
    }
}
