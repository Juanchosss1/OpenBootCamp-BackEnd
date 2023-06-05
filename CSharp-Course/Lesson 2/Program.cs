//Ejercicio 1
/*Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje.
 * Ej: nombre, apellido, edad, sabe programar, etc.*/

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("Enter your lastname: ");
string lastName = Console.ReadLine();
Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Known programing?: (yes/no) ");
string knownPrograming = Console.ReadLine();
bool value;
if(knownPrograming.ToLower() == "yes")
{
    value = true;
}
else
{
    value= false;
}



Console.WriteLine("Hello " + name + " " + lastName + ", you have " + age + " years and known programing: " + value);

//Ejercicio 2
/*
Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

Coche: puertas, ruedas, marca, ITV vigente

Mesa: peso, largo, material, color

Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.
*/
Console.WriteLine("How many doors have: ");
int doors = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many wheels have: ");
int wheels = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Brand:  ");
string brand = Console.ReadLine();
Console.WriteLine("ITV:  ");
string itv = Console.ReadLine();

Console.WriteLine("Your car is a " + brand + " with " + doors + "doors, " + wheels + "wheels and itv: " + value);

Console.WriteLine("Kg: ");
int weigth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("length: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Material:  ");
string material = Console.ReadLine();
Console.WriteLine("color:  ");
string color = Console.ReadLine();

Console.WriteLine("Your table weight " + weigth + ", length " + length + "made of, " + material + "in color " + color);

//Ejercicio 3
/*
Operadores Determina los operadores para verificar las siguientes condiciones:
Un número es mayor o igual a 18
Un char es ‘a’
Se cumplen dos conciones a la vez (ambas verdaderas)
Se cumple una de dos condiciones a la vez (una true y otra false)
*/

bool response;
int number = 0;

if(number >= 18)
{
    response = true;
}

string alpha = "a";

if (alpha == "a")
{
    response = true;
}

if (alpha == "a" && alpha.Length > 0)
{
    response = true;
}

if (alpha == "a" || alpha.Length > 0)
{
    response = true;
}