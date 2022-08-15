using Herencia;

//definiendo e instanciando un objeto de la clase ClientesVentas
ClientesVentas Cliente1 = new ClientesVentas();
Cliente1.IdCliente = 001;
Cliente1.Nombres = "Touru";
Cliente1.Apellidos = "DragonHeart";
Cliente1.Direccion = "C. Jazmin";
Cliente1.Colonia = "Bugambilia";
Cliente1.Municipio = "Eucalipto";
Cliente1.EsCredito = false;

Console.WriteLine($"ID: {Cliente1.IdCliente}\n" +
                  $"NOMBRES: {Cliente1.Nombres}\n" +
                  $"APELLIDOS: {Cliente1.Apellidos}\n" +
                  $"DIRECCION: {Cliente1.Direccion}\n" +
                  $"COLONIA: {Cliente1.Colonia}\n" +
                  $"MUNICIPIO: {Cliente1.Municipio}\n" +
                  $"CREDITO?: {Cliente1.EsCredito}");

