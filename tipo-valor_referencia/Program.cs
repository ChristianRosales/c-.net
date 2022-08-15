//pasando por REFERENCIA
class Entrada
{
    static void Main()
    {   //Aqui se esta definiendo Jerry
        var person = new Persona() { Nombre = "Jerry" };
        //Aqui se esta cambiando la misma propiedad nombre por que solo le esta pasando por parametro
        //la referencia del Nombre, por lo que si se cambia el nombre por que es la misma propiedad
        CambiarNombre(person);
        //Aqui se esta pasando como parametro una copia del valor
        int edad = 25;
        CambiarEdad(edad); //no se va a cambiar la edad por que en el metodo se esta crando otra edad
    }
    static void CambiarNombre(Persona persona)
    {
        persona.Nombre = "Luis";
    }
 
    static void CambiarEdad(int edad)
    {
        edad = 26; //este valor es diferente al de el main ya que aqui se esta creando otro int
    }
}
class Persona
{
    public string Nombre { get; set; }
}