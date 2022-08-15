//Las clases para este ejercicio se alojan en el namespace Polimorfismo
using Polimorfismo;
//Clase MAIN
ClientesContacto cliente1 = new ClientesContacto(1, "Yui", "S33", "ASDF22", 213, "Hirasawa",
    "52 55 221 222", "52 333 444", "ui@mail.com", 
    "Bugambilias", "No. 3", "Int. 6", "Prado", "Kyoto", "Ouken","56900");

Impresion Impresion = new Impresion();
Impresion.ImprimeCliente(cliente1);
//POLIMORISMO se refiere a crear una jerarquia a partir de una super clase
//que utilice esa superclase para definir los parametros en funcionalidades que van a ser comunes para toda la jerarquia (para todas la clases) 