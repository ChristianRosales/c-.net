using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_CicloWhile
{
    //implementacion de la interfaz Intsalidas
    public class Impresion : IntSalidas
    {
        //Aqui solo va a imprimir las propiedades basicas, comunes en todas las clases 
        public void ImprimeCliente(absClientes cliente)
        {
            Console.WriteLine($"- {cliente.Id} - {cliente.Nombre} - {cliente.Clave} - {cliente.RFC} - {cliente.TipoRegimen} - {cliente.NombreContacto}");
        }
        public void ImprimeDireccion(Direcciones direccion)
        {
            Console.WriteLine($"{direccion.Calle} - {direccion.NumeroExterior} - {direccion.NumeroInterior}" +
                $"{direccion.Colonia} - {direccion.Municipio} - {direccion.Estado} - {direccion.CP}");
        }
    }
}
