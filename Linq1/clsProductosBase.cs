using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    public class clsProductosBase : absProductos
    {
        public clsProductosBase()
        {
            IdProducto = 0;
            Clave = "";
            Descripcion = "";
            PrecioPublico = 0m;
            Costo = 0m;
            Existencias = 0;
        }
        public clsProductosBase(int pIdProducto, string pClave, string pDescripcion, decimal pPrecioPublico, decimal pCosto, int pExistencias)
        {
            IdProducto = pIdProducto;
            Clave = pClave;
            Descripcion = pDescripcion;
            PrecioPublico = pPrecioPublico;
            Costo = pCosto;
            Existencias = pExistencias;
        }

        public override int IdProducto { get; set; }
        public override string Clave { get; set; }
        public override string Descripcion { get; set; }
        public override decimal PrecioPublico { get; set; }
        public override decimal Costo { get; set; }
        public override int Existencias { get; set; }

    }
}
