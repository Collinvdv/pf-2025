namespace MyAppNamespace;

internal class Program
{
    private static void Main()
    {
        // Objective: Check if the user is eligible to vote (age 18 or above).
        // O: Enter your age:
        // I: 20
        // O: You are eligible to vote.
//         int age = Convert.ToInt16(Console.ReadLine());
// ;
//         if (age >= 18) {
//             Console.WriteLine("You can vote");
//         } else {
//             Console.WriteLine("You can not vote");
//         }

        // Objective: Determine if a number is positive, negative, or zero.
        // O: Enter a number:
        // I: -5
        // O: The number is negative.
        // int number = Convert.ToInt16(Console.ReadLine());

        // if (number < 0) {
        //     Console.WriteLine("N.");
        // } 
        //     else if (number > 0) 
        // {
        //     Console.WriteLine("P.");
        // } else 
        // {
        //     Console.WriteLine("Z.");
        // }

        // Objective: Find the largest number among three numbers.
        // O: Enter the first number:
        // I: 10
        // O: Enter the second number:
        // I: 25
        // O: Enter the third number:
        // I: 15
        // O: The largest number is 25.
        // int number1 = Convert.ToInt16(Console.ReadLine());
        // int number2 = Convert.ToInt16(Console.ReadLine());
        // int number3 = Convert.ToInt16(Console.ReadLine());

        // if (number1 >= number2 && number1 >= number3) {
        //     Console.WriteLine($"The largest number is {number1}");
        // } else if (number2 >= number1 && number2 >= number3) {
        //     Console.WriteLine($"The largest number is {number2}");
        // } else {
        //     Console.WriteLine($"The largest number is {number3}");
        // }

        // 13:17
        // Objective: Perform basic arithmetic operations using switch-case.
        // O: Enter first number:
        // I: 10
        // O: Enter second number:
        // I: 5
        // O: Enter operator (+, -, *, /):
        // I: *
        // O: The result is 50.
        // double number1 = Convert.ToDouble(Console.ReadLine());
        // double number2 = Convert.ToDouble(Console.ReadLine());
        // string sign = Console.ReadLine(); // "+"
        // double result = 0;

        // if (sign == "+") {
        //     result = number1 + number2;
        // } else if (sign == "-") {
        //     result = number1 - number2;
        // } else if (sign == "*") {
        //     result = number1 * number2;
        // } else if (sign == "-") {
        //     result = number1 - number2;
        // } else if (sign == "/") {
        //     if (number2 == 0) {
        //         Console.WriteLine("error");
        //     } else {
        //         result = number1 / number2;
        //     }
        // }  else {
        //     Console.WriteLine("No correct operator given");
        // }

        // Console.WriteLine(result);

        // WHEN THEY ARE BETWEEN 18 AND 65 THEY CAN ENTER, ONLY FEMALES!!!!
        // int age = Convert.ToInt16(Console.ReadLine());
        // string gender = Console.ReadLine();
        // int bribeMoney = Convert.ToInt16(Console.ReadLine());

        // if (
        //     (age >= 18 && age <= 65 && (gender == "f" || gender == "F"))
        //     ||
        //     (bribeMoney >=50)
        // ) {
        //     Console.WriteLine("Enter");
        // }
        // else 
        // {
        //     Console.WriteLine("Not enter");
        // }

        // Kilometers Over Limit	Urban Area (Binnen de bebouwde kom)	Outside Urban Area (Buiten de bebouwde kom)
        // 5 km/h	€54	€45
        // 10 km/h	€107	€90
        // 20 km/h	€257	€223
        // 25 km/h	€337	€300

        // O: Enter the speed limit:
        // I: 50
        // O: Enter the recorded speed:
        // I: 60
        // O: Are you inside an urban area? (yes/no)
        // I: yes
        // O: You were 10 km/h over the speed limit. Your fine is €107.

        Console.WriteLine("Enter the speed limit:");
        int speedLimit = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter the recorded speed:");
        int recordedSpeed = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Are you inside an urban area? (yes/no)");
        string insideUrbanArea = Console.ReadLine(); // yes or no

        int difference = recordedSpeed - speedLimit;
        int fine = 0;

        if (difference <= 4) {
            Console.WriteLine("No fine");
        } else {
            if (insideUrbanArea.ToLower() == "yes") {
                if (difference <= 5 ) {
                    fine = 54;
                } else if (difference <= 10) {
                    fine = 107;
                } else if (difference <= 20) {
                    fine = 257;
                } else {
                    fine = 337;
                }
            } else {
                if (difference <= 5 ) {
                    fine = 45;
                } else if (difference <= 10) {
                    fine = 90;
                } else if (difference <= 20) {
                    fine = 223;
                } else {
                    fine = 300;
                }
            }

            Console.WriteLine($"You were {difference} km/h over the speed limit. Your fine is €{fine}.");
        }
    }
}
