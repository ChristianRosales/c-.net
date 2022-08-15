using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    public abstract class absProductos
    {
        public abstract int IdProducto { get; set; }
        public abstract string Clave { get; set; }
        public abstract string Descripcion { get; set; }
        public abstract decimal PrecioPublico { get; set; }
        public abstract decimal Costo { get; set; }
        public abstract int Existencias { get; set; }
    }
}
