//Eventos := editor -> suscriptor

SuscriptorCalc calculadora = new SuscriptorCalc(1, 2);
calculadora.ResultadoSuma();
calculadora.ResultadoResta();

/* Editor o publisher
 *Determina cuando se "lanza" el evento
 * - Definicion del evento
 * - Delegaod
 */

public class Editor
{
    public delegate void EjemploEvento();
    public event EjemploEvento ejemploEvento;
}

public class EditorCalc
{
    public delegate void EjemploDelegado();
    public event EjemploDelegado ejemploEvento;

    public void Sumar(int a, int b)
    {
        if(ejemploEvento != null)
        {
            ejemploEvento();
            Console.WriteLine($"La suma es: {a + b}");
        }
        else
        {
            Console.WriteLine("No tienes una suscripción al evento");
        }
    }

    public void Restar(int a, int b)
    {
        if (ejemploEvento != null)
        {
            ejemploEvento();
            Console.WriteLine($"La resta es: {a - b}");
        }
        else
        {
            Console.WriteLine("No tienes una suscripción al evento");
        }
    }

}

/* Suscriptor
 * Acepta el evento y provee un event handler, es decir
 * Método q será ejecutado cuando ocurra el evento
 * 
 */

public class SuscriptorCalc
{
    
    private readonly int A;
    private readonly int B;

    public void EjemploEventHandler()
    {
        Console.WriteLine("Se imprime el resultado de la operación: ");
    }

    public SuscriptorCalc(int a, int b)
    {
        editor = new EditorCalc();
        A = a;
        B = b;
        editor.ejemploEvento += EjemploEventHandler; // Suscripción al evento aquí
    }

    public void ResultadoSuma()
    {
        editor.Sumar(A, B);
    }

    public void ResultadoResta()
    {
        editor.Restar(A, B);
    }
}

/*Evento
 * Delegado encapsulado en la clase del editor
 * Delegado -> llama a un método cuando se cumple una condicion
 * 
 */