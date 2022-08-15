Coords misCoordenadas = new Coords(10, 1, 4);
Console.WriteLine("x: "+misCoordenadas.X);
Console.WriteLine("y: "+misCoordenadas.Y);
Console.WriteLine("z: "+misCoordenadas.Z);
//Aqui estoy creando un nuevo objeto "misCoordenadas2", a partir de otro objeto "misCoordenadas" y le estoy cambiando el valor de X
Coords misCoordenadas2 = misCoordenadas with { X = 3 };
Console.WriteLine(misCoordenadas2);
/*STRUCT es un tipo de dato que represeta estructura
 structse puede utilizar para contener valores de datos pequeños que no requieren herencia, por ejemplo, 
 puntos de coordenadas, pares clave-valo*/
public struct Coords
{
    public Coords(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
//si es get es solo lectura y si es set tambien es escritura
    public double X { get; set; }
    public double Y { get; }
    public double Z { get; }
    public override string ToString() => $"({X}, {Y}, {Z})";
}

//Ref cuando se necesite un objeto de tipo referencia 
