using Clases_Abstractas;

//creamos el objeto con un constructor que puede recibir parametros
ClientesBase cliente1 = new ClientesBase(1, "Yui", "S33", "ASDF22", 213, "Yui Hirasawa");
Console.WriteLine($"- {cliente1.Id} - {cliente1.Nombre} - {cliente1.Clave} - {cliente1.RFC} - {cliente1.TipoRegimen} - {cliente1.NombreContacto}");