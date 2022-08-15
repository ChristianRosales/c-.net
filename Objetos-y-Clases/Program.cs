using Objetos_y_Clases;

//Declaramos el objeto 
Empleados empleado1;
//Instanciamos el objeto
empleado1 = new Empleados();
empleado1.Nombre = "Kasumi";
empleado1.Edad = 22;
empleado1.SueldoDiario = 12.5m;
decimal total;
total = empleado1.CalculaSalario(30);
Console.WriteLine($"El salario mensual del empleado {empleado1.Nombre}");
Console.WriteLine($"Es: {total.ToString("C")}");
Console.ReadKey();