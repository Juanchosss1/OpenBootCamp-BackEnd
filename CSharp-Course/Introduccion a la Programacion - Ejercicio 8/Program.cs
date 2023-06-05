using System;

class Persona
{
    private int edad;
    private string nombre;
    private string telefono;

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Telefono
    {
        get { return telefono; }
        set { telefono = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona();

        // Utilizando los setters para asignar valores
        persona.Edad = 25;
        persona.Nombre = "Juan";
        persona.Telefono = "123456789";

        // Utilizando los getters para mostrar los valores
        Console.WriteLine("Edad: " + persona.Edad);
        Console.WriteLine("Nombre: " + persona.Nombre);
        Console.WriteLine("Teléfono: " + persona.Telefono);
    }
}
