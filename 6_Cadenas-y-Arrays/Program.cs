/*
//CADENAS
string str; //declarado, no inicializado
string str1 = null; // con valor nulo
string str2 = System.String.Empty; // string vacio
string str3 = ""; // con valor ""
string str5 = " "; // con valor de espacio " "
Console.WriteLine(str3.GetType());
Console.WriteLine($"str3: {str3}"); // se muestra como un template
Console.WriteLine(str5.GetType());

//ARRAY

//arreglo de caracteres
char[] letters = { '#', '@', '$' };
//Accedemos a un elemento de un array o de un string con el indice
Console.WriteLine(letters[0]);
string str6 = "Hola soy una cadena";
Console.WriteLine(str6[2]);
//concatenacion 
string msg1 = "Buenos dias";
string msg2 = "estoy programando en c#";

string msg3 = msg1 + ", " + msg2;
Console.WriteLine(msg3);
string msg4 = msg1;
msg4 += msg2;

//LITERALES (insertar caracteres de escape)
// Caracteres escapados -> \n \u00C6 Æ \r \t
string multilinea1 = "Hola" +
                     "Este es un mensaje" +
                     "en varias lineas";
string multilinea2 = @" Hola, este 
                     es un mensaje de
                     varias lineas
                     sin concatenar";
//con @ podemos escribir con notacion libre
string comillas = @"Él se autoproclama ""programador""."; 
Console.WriteLine(multilinea1);
Console.WriteLine(multilinea2);
Console.WriteLine(comillas);

//INTERPOLACIÓN
var persona = (nombre: "Carmen", nacimiento:1980, edad: "22", lenguaje: "C#");
Console.WriteLine($"{persona.nombre} es un hombre de {2022 - persona.nacimiento} años y le gusta programar en {persona.lenguaje}.");

//SUBCADENAS
string miCadena = " Este es mi mensaje  ";
// Substring, Replace
string miCadena2 = miCadena.Substring(0, 10);
Console.WriteLine(miCadena2);
string miCadena3 = miCadena.Replace("mi", "podcast");
Console.WriteLine(miCadena3);
//limpiar espacios
string miCadena4 = miCadena.Trim(); //elimina los espacios al principio y al final de la cadena
Console.WriteLine(miCadena4);
//encontrar caracter
int index = miCadena.IndexOf('m');
Console.WriteLine(index);

string str = "Hola :)";
string nullStr = null;
string emptyStr = String.Empty;
string tempStr = str + nullStr;
Console.WriteLine(tempStr);
bool b = (emptyStr == nullStr);
Console.WriteLine(b);

string newStr = emptyStr + nullStr;
Console.WriteLine(newStr);
Console.WriteLine(emptyStr.Length);
Console.WriteLine(newStr.Length);

//Añadimos valores
nullStr = "a";
Console.WriteLine(nullStr.Length);

emptyStr = "";
emptyStr += nullStr;
Console.WriteLine(emptyStr);

//StringBuilder
StringBuilder sb = new StringBuilder("Rat: the ideal pet");
Console.WriteLine(sb[0]);
Console.WriteLine(sb);

//Transformar una cadena a numero si es posible
int i = 0;
string s = "121221";
bool result = int.TryParse(s, out i);
Console.WriteLine(result + ", i: "+i);
*/
//ARRAYS
int[] arr = new int[2]; // (1, 2)
string[] names = new string[2];
names[0] = "Jhony";
names[1] = "Deep";
Console.WriteLine(names[0] + names[1]);
foreach (string elemento in names)
{
    Console.WriteLine(elemento);
}
int[] numbers = { 4, 3, 8, 0, 5 };
Array.Sort(numbers);
foreach(int element in numbers)
{
    Console.WriteLine(element);
}
// mas tipos de arrays

int[,] miArray2D = new int[2, 2]; // 1, 2
                                  // 3, 4
miArray2D[0, 0] = 1;
miArray2D[0, 1] = 2;
miArray2D[1, 0] = 3;
miArray2D[1, 1] = 4;

for(int j=0; j<2; j++)
{
    for(int k=0; k<2; k++)
    {
        Console.Write(miArray2D[j, k] + " ");
    }
    Console.WriteLine("\n");
}