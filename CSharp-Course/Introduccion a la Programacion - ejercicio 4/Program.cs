using System;

class Program
{
    static void Main(string[] args)
    {
        int numeroIf = 5;

        // If
        if (numeroIf > 0)
        {
            Console.WriteLine("El número es positivo.");
        }
        else if (numeroIf < 0)
        {
            Console.WriteLine("El número es negativo.");
        }
        else
        {
            Console.WriteLine("El número es 0.");
        }

        // While
        int numeroWhile = 0;
        while (numeroWhile < 3)
        {
            Console.WriteLine("Valor de numeroWhile: " + numeroWhile);
            numeroWhile++;
        }

        // Do While
        int numeroDoWhile = 0;
        do
        {
            Console.WriteLine("Valor de numeroDoWhile: " + numeroDoWhile);
            numeroDoWhile++;
        } while (numeroDoWhile < 3);

        // For
        for (int numeroFor = 0; numeroFor <= 3; numeroFor++)
        {
            Console.WriteLine("Valor de numeroFor: " + numeroFor);
        }

        // Switch
        string estacion = "primavera";
        switch (estacion)
        {
            case "invierno":
                Console.WriteLine("Estamos en invierno.");
                break;
            case "primavera":
                Console.WriteLine("Estamos en primavera.");
                break;
            case "verano":
                Console.WriteLine("Estamos en verano.");
                break;
            case "otoño":
                Console.WriteLine("Estamos en otoño.");
                break;
            default:
                Console.WriteLine("No se reconoce la estación.");
                break;
        }
    }
}
