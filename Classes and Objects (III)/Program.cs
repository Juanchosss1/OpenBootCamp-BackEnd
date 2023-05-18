Build building = new Build();

Console.WriteLine("Enter your meters : ");
building.SquareMeters = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Adress");
building.Adress = Console.ReadLine();

building.Welcome("Hellow, my fellow");

building.AddMeters(10);
public interface IHome
{
    void Welcome(string greetings);

    public int SquareMeters { get; set; }

    public string Adress { get ; set; }

    void AddMeters(int meters);
}

class Build : IHome
{
    public int SquareMeters { get ; set ; }
    public string Adress { get; set; }

    public void AddMeters(int meters)
    {
        
        SquareMeters += meters;
        Console.WriteLine($"You added {meters} to your building, extending to {SquareMeters}");
    }

    public void Welcome(string greetings)
    {
        Console.WriteLine($"{greetings} dear user, to {Adress}");
    }
}