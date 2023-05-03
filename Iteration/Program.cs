/*
Ejercicio 1 - While
Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. Es decir, un programa que presente para el 1:
1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10
*/

/*
Console.WriteLine("Enter a number: ");
int multiplication = Convert.ToInt16(Console.ReadLine());
int i = 1;
while(i <= 10)
{
    Console.Write($"{multiplication * i} ");
    i++;
}
*/

/*
Ejercicio 2 - Do while
Escribe un programa que realice estos pasos:
Reciba al menos un número por consola
Determine si el número es positivo o negativo
Presente un contador para cada tipo (positivo y negativo).
Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. Tienes completa libertad para elegir el formato de la salida.
*/


/*
CountNumbers();
static void CountNumbers()
{
    int num = 0;
    int countPos = 0;
    int countNeg = 0;

    do
    {
        Console.WriteLine("Enter a number, 0 to exit: ");
        num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            countPos++;
            Console.WriteLine("Number is positive.");
        }
        else if (num < 0)
        {
            countNeg++;
            Console.WriteLine("Number is negative.");
        }
        else
        {
            Console.WriteLine("End of program.");
        }
    } while (num != 0);

    Console.WriteLine($"There are {countPos} positive numbers and {countNeg} negative numbers.");
}

*/

/*
Ejercicio 3 - For
Escribe un programa que realice estos pasos:
Reciba 3 datos:
ancho
alto
relleno o no
Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si 
el rectángulo está relleno (tiene más * dentro) o no.
En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.
Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla. Ejemplos:
Input: 2,2,2, relleno = true
Output:

****

****

Input: 3, 4, 1, relleno = false

Output:

***

**

**

***
*/

using System;

static void DrawRectangle()
{
    Console.Write("Introduce el ancho: ");
    int ancho = int.Parse(Console.ReadLine());

    Console.Write("Introduce el alto: ");
    int alto = int.Parse(Console.ReadLine());

    Console.Write("¿Relleno (1) o no (0)? ");
    int relleno = int.Parse(Console.ReadLine());

    Console.Write("¿Cuántos rectángulos quieres dibujar? ");
    int cantidad = int.Parse(Console.ReadLine());

    for (int r = 1; r <= cantidad; r++)
    {
        if (ancho == alto)
        {
            // Es un cuadrado
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            // Es un rectángulo
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    if (relleno == 1 || i == 0 || j == 0 || i == alto - 1 || j == ancho - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
DrawRectangle();