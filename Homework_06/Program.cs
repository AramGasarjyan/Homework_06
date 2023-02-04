

//Ստեղծեք delegate -որը ցույց կտա նրա օգտագործումը պարզ մաթեմատիկական օպերացիաների համար

Operationsdelegate add = new Operationsdelegate(Operations.Add);
Operationsdelegate substract = new Operationsdelegate(Operations.Subtract);
Operationsdelegate multiply = new Operationsdelegate(Operations.Multiply);
Operationsdelegate divide = new Operationsdelegate(Operations.Divide);

Console.WriteLine(add(10, 20));
Console.WriteLine(substract(10, 20));
Console.WriteLine(multiply(10, 20));
Console.WriteLine(divide(10, 20));

Client first = new Client("qwerty", "esim ur", "011223344", 99);
Client second = new Client("ytrewq", "ru mise", "443322110", 99);

first.clientdelegate();
second.clientdelegate();


delegate float Operationsdelegate(float first, float second);
delegate void Clientdelegate();

class Operations
{
    public static float Add(float first, float second)
    { return first + second; }

    public static float Subtract(float first, float second)
    { return first - second; }

    public static float Multiply(float first, float second)
    { return first * second; }

    public static float Divide(float first, float second)
    { return first / second; }
}

class Client
{
    string Name;
    string Adress;
    string PhoneNumber;
    int Age;
    public Clientdelegate clientdelegate;
    public Client()
    {
        clientdelegate += GetName;
        clientdelegate += GetAderss;
        clientdelegate += GetPhoneNumber;
        clientdelegate += GetAge;
    }

    public Client(string name, string adress, string phoneNumber, int age) : this()
    {
        Name = name;
        Adress = adress;
        PhoneNumber = phoneNumber;
        Age = age;
    }

    void GetName()
    {
        Console.WriteLine($"Name: {Name}");
    }
    void GetAderss()
    {
        Console.WriteLine( $"Adress: {Adress}");
    }
    void GetPhoneNumber()
    {
        Console.WriteLine( $"PhoneNumber: {PhoneNumber}");
    }
    void GetAge()
    {
        Console.WriteLine( $"Age: {Age}");
    }
}


