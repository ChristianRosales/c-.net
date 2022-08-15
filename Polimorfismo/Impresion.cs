using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Impresion
    {
        //Aqui solo va a imprimir las propiedades basicas, comunes en todas las clases 
        public void ImprimeCliente(absClientes cliente)
        {
            Console.WriteLine($"- {cliente.Id} - {cliente.Nombre} - {cliente.Clave} - {cliente.RFC} - {cliente.TipoRegimen} - {cliente.NombreContacto}");
        }
    }
}

