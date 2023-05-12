
// Actividad 5A

/*

Escribe un programa que:

Pida datos a un cliente: Nombre, email, cupón

Determine si un cliente tiene un cupon descuento

Muestre un precio rebajado en función del descuento

Muestre el precio de un producto sin descuento si no hay cupón

Nota: puedes poner un precio fijo de un producto o uno variable.

*/

Console.Write("Introduce tu nombre: ");
string nombre = Console.ReadLine();

Console.Write("Introduce tu email: ");
string email = Console.ReadLine();

Console.Write("Introduce tu cupón (deja en blanco si no tienes): ");
string cupon = Console.ReadLine().ToUpper();

int precioProducto = 100;

// Comprobamos si el cliente tiene un cupón válido

double descuento = 0;

if (cupon == "DESCUENTO10")
{
    descuento = 0.1;
}
else if (cupon == "DESCUENTO20")
{
    descuento = 0.2;
}

// Aplicamos el descuento al precio del producto

int precioRebajado = (int) ( precioProducto * (1 - descuento));

// Mostramos el precio final al cliente

if (descuento > 0)
{
    Console.WriteLine($"Hola {nombre}, tu precio final con el cupón " +
        $"{cupon} es de {precioRebajado} euros");
}
else
{
    Console.WriteLine($"Hola {nombre}, el precio de nuestro producto " +
        $"es de {precioProducto} euros");
}


// Actividad 5B

/* 

Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++.
Presenta la lista en consola y pide que el usuario seleccione el lenguaje
mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.

Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.

*/


Console.WriteLine("Selecciona un lenguaje de programación:");

Console.WriteLine("1. C#");
Console.WriteLine("2. Java");
Console.WriteLine("3. C++");

int lenguajeProgramacion = int.Parse(Console.ReadLine());

switch (lenguajeProgramacion)
{
    case 1:
        Console.WriteLine("Bienvenido al curso de Java");
        break;
    case 2:
        Console.WriteLine("Bienvenido al curso de C#");
        break;
    case 3:
        Console.WriteLine("Hola mundo");
        break;
    default:
        Console.WriteLine("Selección inválida");
        break;

}