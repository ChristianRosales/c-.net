using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_y_Clases
{
    public class Empleados
    {
        // El CONSTRUCTOR  es un metodo que se ejecuta de manera automatica cuando se instancia un objeto
        // Es publico no retorna nada y tiene el mismo nombre de la clase
        public Empleados()
        {
            Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }

        public string Nombre;
        public decimal SueldoDiario ;
        public int Edad;
        public decimal CalculaSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }
    }
}
