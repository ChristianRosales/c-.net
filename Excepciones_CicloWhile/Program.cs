using Excepciones_CicloWhile;
ClientesContacto cliente1 = new ClientesContacto(1, "Yui", "S33", "ASDF22", 213, "Hirasawa",
    "52 55 221 222", "52 333 444", "ui@mail.com",
    "Bugambilias", "No. 3", "Int. 6", "Prado", "Kyoto", "Ouken", "56900");

//Aqui el objeto impresion esta declarado pero no instanciado
IntSalidas Impresion;
string cadena = Console.ReadLine();
//Aqui estamos instanciando el objeto dependiendo de la condicion
//si es 1 instancia de la clase impresion que imprime desde consola si no desde Archivo que guarda el resultado en un .log
if (cadena == "1")
    Impresion = new Impresion();
else
    Impresion = new Archivos();
try
{
    Impresion.ImprimeCliente(cliente1);
}
catch(Exception e)
{
    Console.WriteLine("Ocurrio un error :( " + e.Message);
    Console.ReadKey();
}
