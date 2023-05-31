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

class Cliente : Persona
{
    private decimal credito;

    public decimal Credito
    {
        get { return credito; }
        set { credito = value; }
    }
}

class Trabajador : Persona
{
    private decimal salario;

    public decimal Salario
    {
        get { return salario; }
        set { salario = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = new Cliente();
        cliente.Edad = 30;
        cliente.Nombre = "Juan";
        cliente.Telefono = "123456789";
        cliente.Credito = 1000.0m;

        Console.WriteLine("Cliente:");
        Console.WriteLine("Edad: " + cliente.Edad);
        Console.WriteLine("Nombre: " + cliente.Nombre);
        Console.WriteLine("Teléfono: " + cliente.Telefono);
        Console.WriteLine("Crédito: " + cliente.Credito);

        Trabajador trabajador = new Trabajador();
        trabajador.Edad = 35;
        trabajador.Nombre = "María";
        trabajador.Telefono = "987654321";
        trabajador.Salario = 2000.0m;

        Console.WriteLine("Trabajador:");
        Console.WriteLine("Edad: " + trabajador.Edad);
        Console.WriteLine("Nombre: " + trabajador.Nombre);
        Console.WriteLine("Teléfono: " + trabajador.Telefono);
        Console.WriteLine("Salario: " + trabajador.Salario);
    }
}
