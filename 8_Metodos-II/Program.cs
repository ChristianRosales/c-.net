/*
float f = 3.1415f;
EscribirNumeroReal(f);
void EscribirNumeroReal(float n){
    Console.WriteLine(n.ToString("#.###"));
}
*/
// RECURSIVIDAD --> funcion que se ejecuta a si misma varias veces

/*
 * Factorial -> !
 * 1! = 1
 * 2! = 2 * 1 = 2
 * 3! = 3 * 2 * 1 = 6
 */
/*
for(int i=1; i<=10; i++)
{
    Console.WriteLine($"{i}!: " + CalcularFactorial(i));
}
long CalcularFactorial(int n)
{
    if(n == 1)
    {
        return 1;
    }
    return n * CalcularFactorial(n - 1);
}
*/
Puerta door = new Puerta();
door.CambiarAltura(200);
door.abrir();
door.estado();
door.cerrar();
door.PintarPuerta("pink");
door.estado();

public class Puerta
{
    int alto;
    int ancho;
    string color;
    string material;
    bool abierta;

    public void CambiarAltura(int n)
    {
        alto = n;
    }
    public void PintarPuerta(string color)
    {
        this.color = color;
    }
    public void abrir()
    {
        abierta = true;
    }
    public void cerrar()
    {
        abierta = false;
    }
    public void estado()
    {
        Console.WriteLine("Alto: {0}", alto);
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("Material {0}:", material);
        Console.WriteLine("Abierta? {0}", abierta);
    }
}