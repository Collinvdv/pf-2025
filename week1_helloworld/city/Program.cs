namespace MyAppNamespace;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Give me your fn:");
        string firstname = Console.ReadLine();
        Console.WriteLine("Give me your ln:");
        string lastname = Console.ReadLine();
        string fullname = firstname + " " + lastname;
        Console.WriteLine(fullname);
    }
}
