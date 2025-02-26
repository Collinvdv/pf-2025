namespace MyAppNamespace;

internal class Program
{
    private static void Main()
    {
        /*
            I: Gent
            O: You live in Gent
        */
        double nbr1 = Convert.ToDouble(Console.ReadLine());
        double nbr2 = Convert.ToDouble(Console.ReadLine());
        double nbr3 = Convert.ToDouble(Console.ReadLine());
        double result = nbr1 + nbr2 + nbr3;

        Console.WriteLine(Math.Floor(result));
    }
}
