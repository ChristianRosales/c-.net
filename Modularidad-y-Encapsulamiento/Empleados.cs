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
        //Encapsulado propiedades
        private string _Nombre;
        public string Nombre 
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        //para encapsular asi escribe prop y presiona tecla tab 2 veces
        public decimal SueldoDiario { get; set; }
        public int Edad { get; set; }
        
        public decimal CalculaSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }
    }
}
