using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            char op;
            bool val; 

            while (continuar)
            {
                Console.WriteLine("--Que desea hacer en la tabla Usuarios?--");
                Console.WriteLine("[C] Agregar");
                Console.WriteLine("[R] Visualizar todos");
                Console.WriteLine("[U] Actualizar");
                Console.WriteLine("[D] Eliminar");
                Console.WriteLine("[G] Obtener un usuario");
                Console.WriteLine("[Q] Salir");
                Console.Write("\n Seleccione una opcion: ");
                
                val = Char.TryParse(Console.ReadLine().ToLower(), out op);
                if (val)
                {
                    Console.WriteLine();
                    switch (op)
                    {
                        case 'c':
                            Usuario.Add();
                            break;
                        case 'r':
                            Usuario.GetAll();
                            break;
                        case 'u':
                            Usuario.Update();
                            break;
                        case 'd':
                            Usuario.Delete();
                            break;
                        case 'g':
                            Usuario.GetById();
                            break;
                        case 'q':
                            Console.WriteLine("Adios :) ...");
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Ingrese una opción valida...");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese una letra de laas opciones");
                }
            }

           
          
        }
    }
}
