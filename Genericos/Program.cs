using Genericos;

string opcion = "";
string cadena = "";
List<ClientesBase> Clientes;
Clientes = new List<ClientesBase>();

while (opcion != "s")
{
    Console.WriteLine("Opciones: ");
    Console.WriteLine("a. Agregar a la lista");
    Console.WriteLine("b. Quitar de la lista");
    Console.WriteLine("c. Imprimir lista");
    Console.WriteLine("\ns. Salir");
    Console.Write("\n[Opcion]: ");
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "a":
            Console.Write("\n[Cliente]: ");
            cadena = Console.ReadLine();
            ClientesBase Cliente = new ClientesBase();
            Cliente.Id = Clientes.Count + 1;
            Cliente.Nombre = cadena;
            Clientes.Add(Cliente);
            break;
        case "b":
            Console.Write("\n[ID Cliente]: ");
            cadena = Console.ReadLine();
            //aqui espera un valor numerico,removeAt elimina el elemento por medio del indice
            Clientes.RemoveAt(Convert.ToInt32(cadena));
            break;
        case "c":
            Console.WriteLine("Los datos del cliente son: ");
            foreach (ClientesBase item in Clientes)
            {
                Console.WriteLine(item.Id.ToString() + " " + item.Nombre);
            }
            break;
        default:
            break;
    }
}
