/*Ejercicio 1
Crea una estructura de datos para un cliente con estos campos:
Nombre completo
Teléfono
Dirección
Email
Si es nuevo cliente
Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
*/
Client newClient = new Client("Juan Perez", 123456, "Salta 1526", "juanperez@gmail.com", true);
Console.WriteLine(newClient);
public struct Client
{
    public Client(string name, int tel, string adress, string email, bool newClient)
    {
        Name = name;
        Tel = tel;
        Adress = adress;
        Email = email;
        NewClient = newClient;
    }
    public string Name { get; set; }
    public int Tel { get; set; }
    public string Adress { get; set; }
    public string Email { get; set; }
    public bool NewClient { get; set; }

    public override string ToString() => $"Client: {Name} \n Tel: {Tel} \n Adress: {Adress} \n Email: {Email} \n New Client: {NewClient}";
   
}