using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Interfaces
{
    //Esta clase va a escribir la salida en un archivo
    public class Archivos : IntSalidas
    {
        public void ImprimeCliente(absClientes cliente)
        {
            //Escribiendo la salida en un archivo
            //dentro del constructor lleva la ruta y un bool que indica que va a sobreescribir el archivo y no lo crea cada vez que lo abre
            StreamWriter ar = new StreamWriter(@"C:\Users\onix\Documents\archPrueba\ArchBitacora.log", true);
            ar.WriteLine($"- {cliente.Id} - {cliente.Nombre} - {cliente.Clave} - {cliente.RFC} - {cliente.TipoRegimen} - {cliente.NombreContacto}");
            ar.Close();
        }
        public void ImprimeDireccion(Direcciones direccion)
        {
            StreamWriter ar = new StreamWriter(@"C:\Users\onix\Documents\archPrueba\ArchBitacora.log", true);
            ar.Close();

        }

    }
}
