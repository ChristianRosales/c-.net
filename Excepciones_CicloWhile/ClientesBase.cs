using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_CicloWhile
{
    //clase que hereda de una clase abstracta
    public class ClientesBase : absClientes
    {
        // Constructor
        public ClientesBase()
        {
            // Inicilizando atributos
            Id = 0;
            Nombre = string.Empty;
            Clave = string.Empty;
            RFC = string.Empty;
            TipoRegimen = 0;
            NombreContacto = string.Empty;
        }
        //constructor con parametros, recibe los valores y se los asigna a las propiedades
        public ClientesBase(int pId, string pNombre, string pClave,
                            string pRFC, int pTipoRegimen, string pNombreContacto)
        {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            RFC = pRFC;
            TipoRegimen = pTipoRegimen;
            NombreContacto = pNombreContacto;
        }
        //ANULACION DE METODO
        /*La creación de un método en la clase derivada 
         * con la misma firma que un método en la clase base se llama como anulación de método. */
        //https://es.acervolima.com/c-anulacion-de-metodo-1/
        //propiedades
        /*Overriding: es una característica que permite que una subclase o clase secundaria 
         * proporcione una implementación específica de un método que ya es proporcionado 
         * por una de sus superclases o clases padre*/
        public override int Id { get; set; }
        public override string Nombre { get; set; }
        public override string Clave { get; set; }
        public override string RFC { get; set; }
        public override int TipoRegimen { get; set; }
        public override string NombreContacto { get; set; }

    }
}
