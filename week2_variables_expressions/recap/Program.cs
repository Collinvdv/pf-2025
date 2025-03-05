namespace MyAppNamespace;

internal class Program
{
    private static void Main()
    {
        // this is a recap of the class
        //string firstName = Console.ReadLine();
        // Console.WriteLine("Hello, " + firstName);

        // O: What is your favorite color? 
        // I: Blue
        // O: Wow! Blue is a great color.
        // Console.WriteLine("What is your favorite color? ");
        // string color = Console.ReadLine();
        // Console.WriteLine("Wow! " + color + " is a great color.");
        // Console.WriteLine($"Wow! {color} is a great color.");

        // O: Enter the first word: 
        // I: Happy
        // O: Enter the second word: 
        // I: Birthday
        // O: HAPPY BIRTHDAY
        Console.WriteLine("Enter the first word: ");
        string firstWord = Console.ReadLine();
        Console.WriteLine("Enter the second word: ");
        string secondWord = Console.ReadLine();
        Console.WriteLine($"{firstWord.ToUpper()} {secondWord.ToUpper()}");
    }
}
