Puerta door = new Puerta();

door.changeWidth(2.5f);
door.doorStatus();


public class Puerta

{
    float width = 0f;
    float height = 0f;
    string material = "steel";
    bool isOpen = false;

    public void changeWidth(float width)
    {
        this.width = width;
    }

    public void changeHeight(float height)
    {
        this.height = height;
    }

    public void changeMaterial(string material)
    {
        this.material = material;
    }

    public void doorStatus()
    {
        Console.WriteLine($"Width: {width}");
        Console.WriteLine($"Heiht: {height}");
        Console.WriteLine($"Material: {material}");
        Console.WriteLine($"¿is open? {isOpen}");
    }
}