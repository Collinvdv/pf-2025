namespace MyAppNamespace;

internal class Program
{
    private static void Main()
    {
       // Objective: Ask the user for their name and age, then calculate their age in 10 years.

        // O: Enter your name: 
        // I: Alice
        // O: Enter your age: 
        // I: 25
        // O: Hello Alice, in 10 years you will be 35 years old.
        // Console.WriteLine("Enter your name: ");
        // String firstName = Console.ReadLine();

        // Console.WriteLine("Enter your age:");
        // int age = Convert.ToInt16(Console.ReadLine());

        // age += 10;

        // Console.WriteLine($"Hello {firstName}, in 10 years you will be {age} years old.");

        // Objective: Get two numbers from the user and display their sum.
        // O: Enter the first number: 
        // I: 8
        // O: Enter the second number: 
        // I: 12
        // O: The sum is: 20
        // O: The division is: 0.6666666
        // Console.WriteLine("Enter the first number: ");
        // double firstNumber = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine("Enter the second number: ");
        // double secondNumber = Convert.ToDouble(Console.ReadLine());

        // double sum = firstNumber + secondNumber;
        // Console.WriteLine("The sum is: " + sum);

        // double division = firstNumber / secondNumber;
        // Console.WriteLine($"The division is {division}");

        // Objective: Convert a temperature from Celsius to Fahrenheit.
        // Temperature in degrees Celsius (°C) * 9/5) + 32
        // O: Enter temperature in Celsius: 
        // I: 25
        // O: 25C is equal to 77F.

        // double celcius = Convert.ToDouble(Console.ReadLine()); 
        // double fahrenheit = (celcius * 9 / 5) + 32;
        // Console.WriteLine($"{celcius}C is equal to {fahrenheit}F.");

        // Objective calculate BMI (BMI = kg/m2) 
        // O: Enter your weight (kg): 
        // I: 70
        // O: Enter your height (m): 
        // I: 1.75
        // O: Your BMI is 22.86
        Console.WriteLine("Enter your weight (kg): ");
        double w = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your height (m): ");
        double h = Convert.ToDouble(Console.ReadLine());
        // double bmi = w / (h * h);
        double bmi = w / (Math.Pow(h, 2));
        Console.WriteLine(bmi);
    }
}
