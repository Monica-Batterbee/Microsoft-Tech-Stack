class Car
{
    private string type = "vehicle";
    public void vehicle()
    {
        Console.WriteLine("This class is car");
        Console.WriteLine($"Type: {type}");
        Console.WriteLine();
    }
}

class Dog : Car
{
    private string type = "animal";
    public void animal()
    {
        Console.WriteLine("This class is animal");
        Console.WriteLine($"Type: {type}");
        Console.WriteLine();
    }
}

class Teacher : Dog
{
    private string type = "person";
    public void person()
    {
        Console.WriteLine("This class is person");
        Console.WriteLine($"Type: {type}");
        Console.WriteLine();
    }
}


class Program
{
    static void Main()
    {
        Car c = new Car();
        c.vehicle();

        Dog d = new Dog();
        d.animal();

        Teacher t = new Teacher();
        t.person();
    }
}
