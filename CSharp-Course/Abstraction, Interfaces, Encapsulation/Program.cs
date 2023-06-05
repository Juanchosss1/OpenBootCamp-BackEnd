Person persona = new Person();
Console.WriteLine($"Tu persona se llama : {persona.Name}, {persona.LastName}, maneja? {persona.knowDrive}");
public interface IPerson
{
    string Name { get; set; }
    string LastName { get; set; }
    DateOnly Birthday { get; set; }
    bool knowDrive { get; set; }

    public void AskName();
    public void AskLastName();
    public void AskDrive();
    //public void CalculateBirthday();
}

public class Person : IPerson
{
    public Person() {
    AskName(); 
    AskLastName();
    AskDrive();
    }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateOnly Birthday { get; set; }
    public bool knowDrive { get; set; }

    public void AskName() {
        Console.WriteLine("Enter a Name: ");
        string name = Console.ReadLine();
        Name = name;
    }
    public void AskLastName()
    {
        Console.WriteLine("Enter a Lastname: ");
        string lastname= Console.ReadLine();
        LastName = lastname;
    }
    public void AskDrive() {
        Console.WriteLine("do you know how to drive? (y/n)");
        string response = Console.ReadLine();
        if (response == "y")
        {
            knowDrive = true;
        }else if (response == "n")
        {
            knowDrive= false;
        }else
        {
            Console.WriteLine("Please, enter a valid answer (y/n)");
        }
    }
    //public void CalculateBirthday();
}