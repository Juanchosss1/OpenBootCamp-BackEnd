
/*
Ejercicio 1 - If

Escribe un programa que:

Pida datos a un cliente: Nombre, email, cupón

Determine si un cliente tiene un cupon descuento

Muestre un precio rebajado en función del descuento

Muestre el precio de un producto sin descuento si no hay cupón

Nota: puedes poner un precio fijo de un producto o uno variable.
*/


//DiscountMachine();
static void DiscountMachine()
{
    Console.WriteLine("Enter your name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Enter your email: ");
    string email = Console.ReadLine();
    Console.WriteLine("Do you have a coupon? (y/n)");
    string haveCoupon = Console.ReadLine();
    Console.WriteLine("Enter price of the product: ");
    float price = Convert.ToInt64(Console.ReadLine());
    float couponDiscount = 1.15f;

    if(haveCoupon == "y")
    {
        Console.WriteLine($"Hello {name}, the price of your product (${price}) it´s now to ${price / couponDiscount} with your coupon ");
    }
    else
    {
        Console.WriteLine($"Hello {name}, the price of your product ({price})");
    }

}

/*
Ejercicio 2 - Switch

Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.

Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.
 */
LenguageMachine();
static void LenguageMachine()
{
    Console.Write("Enter your favourite lenguage:\n1-\tC# \n2 -\tJava\n3-\tC++\n4-\tJavaScript\n");
    int option = Convert.ToInt32(Console.ReadLine());
    switch(option)
    {
        case 1:
            Console.WriteLine("You choose C#");
            break;
        case 2:
            Console.WriteLine("You choose Java");
            break;
        case 3:
            Console.WriteLine("You choose C++");
            break; 
        case 4:
            Console.WriteLine("You choose JavaScript");
            break;
        default: Console.WriteLine("enter a valid number");
            break;
    }

}
