class Entrada
{
    static void Main()
    {
        /*
        int entero = 10;
        // CASTING -> convirtiedo a otro tipo de dato 
        // Conversiones explicitas
        float flotante = (float)entero;
        // Conversiones implicitas
        float flotanteimp = entero;
        */
        int entero = 10;
        object objeto = entero; // BOXING -> Convertir un tipo valor a un tipo referencia

        int entero2 = (int)objeto; // UNBOXING -> convertir de referencia a valor


    }
}