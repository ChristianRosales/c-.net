using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        public static void Add()
        {
            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("\n--INSERTANDO USUARIO--");
            Console.Write("\nIngrese Nombres: ");
            usuario.Nombres = Console.ReadLine();
            Console.Write("\nIngrese Apellidos: ");
            usuario.Apellidos = Console.ReadLine();
            Console.Write("\nIngrese Fecha Nac: ");
            usuario.FNacimiento = DateTime.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.Add(usuario);
            if (result.Correct)
            {
                Console.WriteLine("\nUsuario registrado con exito\n");
            }
            else
            {
                Console.WriteLine("Ocurrio un error al registrar al Usuario" + result.ErrorMessage);
            }
        }

        public static void Update()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("\n--ACTUALIZANDO USUARIO--");
            Console.Write("\nIngrese ID: ");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            Console.Write("\nIngrese Nombres: ");
            usuario.Nombres = Console.ReadLine();
            Console.Write("\nIngrese Apellidos: ");
            usuario.Apellidos = Console.ReadLine();
            Console.Write("\nIngrese Fecha Nac: ");
            usuario.FNacimiento = DateTime.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.Update(usuario);
            if (result.Correct)
            {
                Console.WriteLine("\nUsuario actualizado con exito\n");
            }
            else
            {
                Console.WriteLine("Ocurrio un error al actualizar al Usuario" + result.ErrorMessage);
            }

        }

        public static void Delete()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("\n--ELIMINANDO USUARIO--");
            Console.Write("\nIngrese ID: ");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.Delete(usuario);
            if (result.Correct)
            {
                Console.WriteLine("\nUsuario eliminado con exito\n");
            }
            else
            {
                Console.WriteLine("Ocurrio un error al eliminar al Usuario" + result.ErrorMessage);
            }

        }

        public static void GetAll()
        {
            
            ML.Result result = BL.Usuario.GetAllSP();

            foreach (ML.Usuario usuarioActual in result.Objects)
            {
                Console.WriteLine($"ID: {usuarioActual.IdUsuario} NOMBRE: {usuarioActual.Nombres}");
            }
        }

        public static void GetById()
        {            
            Console.WriteLine("\n--BUSCADO USUARIO--");
            Console.Write("\nIngrese ID: ");
            int id = int.Parse(Console.ReadLine());
            ML.Result result = BL.Usuario.GetByIdSP(id);
            if (result.Correct)
            {
                ML.Usuario usuarioActual = (ML.Usuario)result.Object;
                Console.WriteLine($"ID: {usuarioActual.IdUsuario} NOMBRE: {usuarioActual.Nombres}");
            }
                

        }

    }
}
