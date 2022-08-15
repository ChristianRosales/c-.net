//Generics
//Generic<string> str = new Generic<string>();
//str.Dato = "dato";
//Console.WriteLine($"Generic Dato: {str.Dato}");
//Console.WriteLine($"Generic Dato Tipo: {str.Dato.GetType}");
//public class Generic<T>
//{
//    public T Dato { get; set; }

//}

//INTERACES 
//Una interaz es un contrato (serie de condiciones que se tiene que cumplir) si no se cumplen no se ejecuta
//Se puede ver como un tipo de plantilla que define que tipos de terminos va a tener nuestra estructura de datos
//Son clases que definen atributos, metodos, etc. sin implementar, son plantillas que se pueden usar para crear nuestras clases

Vehiculo v1 = new Vehiculo();
v1.Marca = "Chevrolet";

interface IVehiculo
{
    public string Marca { get; set; }
    void arrancar();

}
class Vehiculo : IVehiculo
{
    public string Marca { get; set; }
    void IVehiculo.arrancar()
    {
        Console.WriteLine("Arrancar");
    }
}



