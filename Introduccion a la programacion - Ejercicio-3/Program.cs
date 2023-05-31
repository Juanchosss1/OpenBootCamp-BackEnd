using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;
        int num3 = 3;

        int resultado = SumarNumeros(num1, num2, num3);
        Console.WriteLine("El resultado de la suma es: " + resultado);
    }

    static int SumarNumeros(int a, int b, int c)
    {
        int suma = a + b + c;
        return suma;
    }
}
class Coche
{
    private int numPuertas;

    public void IncrementarPuertas()
    {
        numPuertas++;
    }

    public int ObtenerNumPuertas()
    {
        return numPuertas;
    }
    static void Main(string[] args)
    {
        Coche miCoche = new Coche();
        miCoche.IncrementarPuertas();
        Console.WriteLine("El coche tiene " + miCoche.ObtenerNumPuertas() + " puertas.");
    }

}


