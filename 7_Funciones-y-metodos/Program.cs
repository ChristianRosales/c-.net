/*
//FUNCIONES
// Main 

int resultado = Cuadrado(2); //4
Console.WriteLine(resultado); //4
CalcularAprobado(1);
CalcularAprobado(6);
CalcularAprobado(10);
// Scope, Contexto
int i = 0;
Console.WriteLine("i desde el main: "+i);
// Scope(i); en este caso el valor de i no se esta modificando desde el main solo desde la funcion 
int a = Scope(i);
Console.WriteLine("valor final de i: " + a);

// End Main

// Deiniciones de las funciones 
//--funcion que devuelve un entero recibiendo un entero
int Cuadrado(int n) 
{
    return n * n; //int
}
int Scope(int a)
{
    a = a + 1;
    Console.WriteLine("i desde fun: " + a);
    return a;
}
//--funcion que no devuelve nada pero recibe un entero
void CalcularAprobado(int a)
{
    if (a < 6)
    {
        Console.WriteLine("reprobado :(");
    }
    else if (a == 6)
    {
        Console.WriteLine("pansaste :o");
    }
    else
    {
        Console.WriteLine("aprobado :)");
    }
}
// End Deiniciones de las funciones 
*/

//METODOS
//son funciones que permiten efectuar el objeto que nos rinden un servicio durante el transcurso del programa
//son acciones de los objetos 

//MAIN
//instancia de objeto de la clase moto
var moto1 = new Motos();
moto1.Arrancar(); //con objeto 
Motos.Arrancar2(); // con clase
// Extensión
_7_Funciones_y_metodos.ExtensionMoto.Acelerar();
// Retorno de metodos
int gasolina = moto1.CantidadGasolina();
Console.WriteLine($"Nos quedan {gasolina} lt de combustible");
// sobrecarga de metodos
dynamic ltRegarcados = moto1.CargarGasolina(1.6d); // ajusta el tipo de dato al que vamos a utilizar
Console.WriteLine($"Tanque: {ltRegarcados} lt de combustible");


//DEFINICIONES
//definicion de clase Moto
class Motos // si no hay modificador de acceso entonces por defecto es publico
{   //definicion de metodo de la clase moto
    public void Arrancar() //public -> modiicador de acceso (publico, privado, etc)
    {
        Console.WriteLine("Arrancar");
    }
    public static void Arrancar2() // static -> delante de un metodo lo convierte en un metodo de clase
                            //se puede ejecutar sin crear un objeto de la clase
    {
        Console.WriteLine("Arrancando con clase");
    }
    public int CantidadGasolina()
    {
        int gasolina = 2;
        return gasolina;
    }
    public int CargarGasolina(int litrosIn)
    {
        int ltCargados = 2 + litrosIn;
        return ltCargados;
    }
    public float CargarGasolina(float litrosIn)
    {
        float ltCargados = 2 + litrosIn;
        return ltCargados;
    }
    public double CargarGasolina(double litrosIn)
    {
        double ltCargados = 2 + litrosIn;
        return ltCargados;
    }

}
