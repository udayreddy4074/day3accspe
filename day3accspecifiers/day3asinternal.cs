using WiproDay3Demo;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("internal acess specifier");
        Customer cs = new Customer();
        cs.custId = 1;
        cs.custName = "UDAY ";
        Console.WriteLine("using internal access specifier");
        cs.Display();


    }
}