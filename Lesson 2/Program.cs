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



Console.WriteLine("Hello " + name + " " + lastName);
