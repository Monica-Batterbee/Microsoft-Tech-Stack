//Composition example

public class CompChild
{
    public void Display()
    {
        Console.WriteLine("Composition Child class");
    }
}

public class CompParent
{
    private CompChild child;

    public CompParent()
    {
        child = new CompChild();
    }

    public void Run()
    {
        child.Display();
    }
}


//Aggregation example

public class AggregationChild
  {
    public void Display()
    {
        Console.WriteLine("Aggrgation Child class");
    }
}

public class AggregationParent
{
    private AggregationChild child;

    public AggregationParent(AggregationChild child)
    {
        this.child = child;
    }

    public void run()
    {
        child.Display() ;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CompParent Cparent = new CompParent();
        Cparent.Run();

        AggregationChild Achild = new AggregationChild();
        AggregationParent Aparent = new AggregationParent(Achild);
        Aparent.run();
    }
}


