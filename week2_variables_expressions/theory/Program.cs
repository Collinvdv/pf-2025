namespace MyAppNamespace;

internal class Program
{
    private static void Main()
    {
        // int age = 33;
        // double height = 1.93;
        // string firstName = "Collin";
        // string lastName = "Van der Vorst";
        // char driveLicense = 'a';
        // Console.WriteLine("My age is " + age);
        // Console.WriteLine("My height is " + height + "m.");

        // age = age - 1;
        // age -= 1;
        // age--;

        // age = age + 2;
        // age += 2;

        // age = age * 2;

        // int number1 = 10;
        // int number2 = 200;

        // int result1, result2; 

        // // Ambiguous 
        // result1 = number1 + number2 / 100;

        // // Unambiguous, recommended 
        // result2 = number1 + (number2 / 100);

        // Console.WriteLine(result1);
        // Console.WriteLine(result2);

        // Console.Write("C");
        // Console.Write("O");
        // Console.Write("L");

        // Scenario 1: O: COL
        // Scenario 2: 
        // O: C
        // O: O
        // O: L
        
        // int asciiNbr = Console.Read();
        // char c = Convert.ToChar(70);
        // Console.WriteLine(c);

        double number = Convert.ToDouble(Console.ReadLine());
        double nextYearNumber = number + 1;
        Console.WriteLine("Next year you will be " + nextYearNumber);
    }
}
