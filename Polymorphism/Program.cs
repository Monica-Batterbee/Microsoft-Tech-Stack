class Program
{
    public void greet()
    {
        Console.WriteLine("Hello");
    }

    public void greet(string name)
    {
        Console.WriteLine($"Hello {name}");
    }

    static void Main( string[] args)
    {
        Program p = new Program();
        p.greet();
        p.greet("World");
    }
}