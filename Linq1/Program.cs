// LINQ 
// 1. Nuestro origen de datos
int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
string[] names = new string[] { "Yui", "Mugi", "Nezuko", "Mio" };
// 2. Obtener datos con una consola
var pares =
    from number in numbers
    where (number % 2) == 0
    select number;
var tresCaracteres =
    from name in names
    where (name.Length > 3)
    select name;
// C#

foreach (var num in pares)
{
    Console.WriteLine(num + " ");
}
foreach (var element in tresCaracteres)
{
    Console.WriteLine(element + " ");
}

//Tipos Anonimos

var coche = new { Marca = "FORD", Km = 0 };
Console.WriteLine($"Tengo un coche marca {coche.Marca} y tiene {coche.Km} km");
