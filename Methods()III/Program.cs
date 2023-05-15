Person person = new Person();
person.Age = 10;
person.Name = "Pepito";
Console.WriteLine($"Your character is named as {person.Name} and is {person.Age} years old"); 

public class Person
{
    private int _age;
    private string _name;
    private DateTime _dateCreated;

    public int Age { get { return _age; } set { _age = value; } }
    public string Name { get { return _name; } set { _name = value; } }
}