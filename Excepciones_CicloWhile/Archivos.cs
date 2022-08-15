using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Excepciones_CicloWhile
{
    //Esta clase va a escribir la salida en un archivo
    public class Archivos : IntSalidas
    {
        public void ImprimeCliente(absClientes cliente)
        {   //Encierra dentro de un TRY todas las instruccionesque pudieran estar relacionadas con la excepcion
            int i = 0;
            bool bandera = true;
            while (bandera)
            {
                try
                {
                    //Escribiendo la salida en un archivo
                    //dentro del constructor lleva la ruta y un bool que indica que va a sobreescribir el archivo y no lo crea cada vez que lo abre
                    StreamWriter ar = new StreamWriter(@"C:\Users\onix\Documents\archPrueba\ArchBitacora.log", true);
                    ar.WriteLine($"- {cliente.Id} - {cliente.Nombre} - {cliente.Clave} - {cliente.RFC} - {cliente.TipoRegimen} - {cliente.NombreContacto}");
                    ar.Close();
                    bandera = false;
                }
                //CATCH para capturar la excepcion 
                catch (Exception e)
                {
                    i++;
                    if(i >= 200)
                    //al capturar la excepcion podemos mandar un mensaje o en este caso transferir el error al  objeto de la excepcion para que el lo maneje
                    throw e;
                }
            }
        }
        public void ImprimeDireccion(Direcciones direccion)
        {
            StreamWriter ar = new StreamWriter(@"C:\Users\onix\Documents\archPrueba\ArchBitacora.log", true);
            ar.Close();

        }

    }
}
