/*
//BUCLES
//WHILE - MIENTRAS  repite una operación mientras sea verdadera una condición
Console.WriteLine("WHILE: ");
int i = 0;
while (i<10)
{
    Console.Write(i + " ");
    i++;
}
//FOR - PARA    repite una operación mientras sea verdadesra una condición, hasta el numero de veces que le indiques
Console.WriteLine("\nFOR: ");
for(int j=1; j<=10; j++) //asignando 1 a la i
{
    Console.Write(j + " ");
}
//DO... WHILE - HACER... MIENTRAS repite una operación mientras sea verdadera una condicion -> a diferencia del while, ejecuta la orden una vez siempre
// se utiliza en el caso de que queramos que se ejecuta la operacion al menos una vez
Console.Write("\nDO... WHILE: ");
i = 5;
do
{
    Console.Write(i + " ");
    i += 5;    // i = i + 5;
} while (i <= 10);
//FOREACH se utiliza, normalmente, en colecciones para ahorrar codigo ya que va iterando cada elemento de la coleccion 
//var para generar cualquier tipo de objetos
Console.WriteLine("\nFOREACH: ");
var lst = new List<string> { "BMW", "Ducati", "Mitsubishi" };
foreach(var elemento in lst)
{
    Console.WriteLine(elemento);
}

//EJEMPLOS DE BUCLES
//Sumar los 100 numeros enteros
//suma = 1 + 2 + ... + 99 + 100
int suma = 0;
for (int n = 1; n <= 100; n++)
{
    suma += n;
}
Console.WriteLine("Resultado suma: " + suma);
//Expandimos el codigo para que el usuario indique un numero  hasta donde vamos a sumar
int resultao = 0;
Console.WriteLine("Ingrese un limite de suma: ");
int limite = Convert.ToInt32(Console.ReadLine());
for (int m = 1; m <= limite; m++)
{
    resultao += m;
}
Console.WriteLine("Resultado suma: " + resultao);

//Escribir todos los elementos de un array
int[] arr = new int[3];
for(int i = 0; i< arr.Length; i++)
{
    Console.Write("\nIngresa numero en posicion [" + i + "]: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (var item in arr)
{
    Console.WriteLine(item);
}

// IF / ELSE
Console.Write("Qué dia es hoy? : ");
string dia = Console.ReadLine().ToLower();
if (dia == "Lunes") Console.WriteLine("Feliz Lunes :)");
else Console.WriteLine("Hoy no es Lunes");
//SWITCH
switch (dia)
{
    case "lunes": Console.WriteLine("Es lunes"); //instrucción
        break; // para la ejeción
    case "martes": Console.WriteLine("Es martes");
        break;
    default: Console.WriteLine("Ese día no lo conozco..."); //cuando no se cumplen los casos 
        break;
}
//BREAK para la ejecución del bucle
if (dia == "lunes")
{
    for(int i=0; i<3; i++)
    {
        Console.WriteLine("lunes");
        break;
    }
    Console.WriteLine("Despues del break");
}
Console.WriteLine("Despues del IF");

//CONTINUE salta al bucle externo
for(int x=0; x<10; x++)
{
    Console.WriteLine(x);
    if(x == 5)
    {
        Console.Write("x es igual a 5");
        continue;
    }
}
*/

int num = 100;
Console.WriteLine(Math.Sqrt(num));

float num2 = 9.29f;
Console.WriteLine(Math.Round(num2));

float num3 = 9.01f;
Console.WriteLine(Math.Ceiling(num3));
Console.WriteLine(Math.Floor(num3));

Console.WriteLine(Math.Max(num2, num3));
Console.WriteLine(Math.Min(num2, num3));