namespace MyAppNamespace;

internal class Program
{
    private static void Main()
    {
        // for loop 
        // count from 1 till 10 
        // for (start; expression; step) {
        // }
        // for (int i = 1; i <= 10; i++) {
        //     Console.WriteLine(i);
        // }

        // Count from 10 till 1 
        // for (int number = 10; number >= 1; number--) {
        //     Console.WriteLine(number);
        // }

        // Count from 0 till 100
        // O: 0
        // O: 2
        // O: 4
        // O: ..
        // O: 100
        // for (int i = 0; i <= 100; i+=2) {
        //     Console.WriteLine(i);
        // }

        // for (int i = 0; i <= 100; i--) {
        //     if (i % 2 == 0) {
        //         Console.WriteLine(i);
        //     }
        // }

        // Assignment on Multiplication Table
        // Objective: Print the multiplication table of a given number using a for loop.
        // O: Enter a number:
        // I: 5
        // O:
        // 5 x 1 = 5
        // 5 x 2 = 10
        // ...
        // 5 x 10 = 50
        // Console.WriteLine("Enter a number:");
        // int baseNumber = Convert.ToInt16(Console.ReadLine());

        // for (int x = 1; x <= 10; x++) {
        //     int result = x * baseNumber;
        //     Console.WriteLine($"{baseNumber} x {x} = {result}");
        // }

        // Assignment on Sum of First N Natural Numbers
        // Objective: Compute the sum of first N natural numbers using a for loop.
        // O: Enter a number N:
        // I: 5
        // O: The sum of first 5 natural numbers is 15.

        // O: Enter a number N:
        // I: 7
        // O: The sum of first 7 natural numbers is 28.
        // int result = 0;
        // int number = Convert.ToInt16(Console.ReadLine()); // 7

        // if (number > 0) {
        //     for (int x = 1; x <= number; x++) {
        //         result += x;
        //     }
        //     Console.WriteLine($"The sum of first {number} natural numbers is {result}.");
        // } else {
        //     Console.WriteLine("Only positive numbers");
        // }

        // Console.WriteLine("Pssst, what is password");
        // string secretPassword = Console.ReadLine(); // apple

        // while (secretPassword != "knockknock") {
        //     Console.WriteLine("Sorry, this one is not correct. Try a new one;");

        //     Console.WriteLine("Pssst, what is password");
        //     secretPassword = Console.ReadLine(); // apple
        // }

        // string secretPassword = "";
        
        // do {
        //     Console.WriteLine("Pssst, what is password");
        //     secretPassword = Console.ReadLine(); // apple
        // } while (secretPassword != "knockknock");

        // Console.WriteLine("YOU CAN ENTER");



        // Objective: Simulate ATM withdrawal with unlimited attempts using a while loop.
        // 
        // O: Enter PIN:
        // I: 1234
        // O: Incorrect PIN. Try again.
        // I: 5678
        // O: Incorrect PIN. Try again.
        // I: 1234
        // O: AFTER 3 ATTEMPTS, YOU CAN ENTER THE ATM

        // string correctPin = Console.ReadLine();

        // string userPin = Console.ReadLine();
        // int attempts = 1;

        // while (userPin != correctPinxw) {
        //     Console.WriteLine("Incorrect PIN. Try again.");

        //     attempts++;
        //     userPin = Console.ReadLine();
        // }

        // Console.WriteLine($"AFTER {attempts} ATTEMPTS, YOU CAN ENTER THE ATM");


        // 
        // Objective: Check if a number is prime using a for loop.
        // O: Enter a number:
        // I: 7
        // O: 7 is a prime number.

        // // initial value
        // int number = Convert.ToInt32(Console.ReadLine()); // 7
        // // next prime number that we will search 
        // bool isNextPrimeNumber = false; 

        // while (isNextPrimeNumber == false) {
        //     number++;

        //     bool isPrimeNumber = true; 
    
        //     for (int x = 2; x < number; x++) {
        //         if (number % x == 0) {
        //             isPrimeNumber = false;
        //             break;
        //         }
        //     }

        //     if (isPrimeNumber) {
        //         isNextPrimeNumber = true;
        //         Console.WriteLine("Next prime number is " + number);
        //     } 
        // }


        // Objective: Keep asking for numbers until the user enters -1. Then, print the sum of all numbers entered.
        // O: Enter a number (-1 to stop):
        // I: 10
        // O: Enter a number (-1 to stop):
        // I: 5
        // O: Enter a number (-1 to stop):
        // I: -1
        // O: The total sum is 15.

        // Console.WriteLine("Enter a number (-1 to stop):");
        // int number = Convert.ToInt16(Console.ReadLine());
        // int result = 0;

        // while (number != -1) {
        //     result += number;

        //     // Ask it again since -1 was entered
        //     Console.WriteLine("Enter a number (-1 to stop):");
        //     number = Convert.ToInt16(Console.ReadLine());
        // }

        // Console.WriteLine($"The total sum is {result}");

        // // Objective: Simulate a random walk where a number moves up/down randomly until it reaches 10 or -10.
        // O: Current position: 0
        // O: Move up! (Current position: 1)
        // O: Move down! (Current position: 0)
        // O: Move up! (Current position: 2)
        // ...
        // O: Reached position 10! Stopping.

        // Objective: Simulate a random walk where a number moves up/down randomly until it reaches 5 or -5.
        // O: Current position: 0
        // O: Move up! (Current position: 1)
        // O: Move down! (Current position: 0)
        // O: Move up! (Current position: 1)
        // ...
        // O: Reached position 5! Stopping.
        // -1, 0 , 1
        // -1 one step backword
        // 0 neutral
        // 2 one step forward

        int curPosition = 0; 
        Random rd = new Random();

        while (true) {
            System.Threading.Thread.Sleep(500);
            int randomNumber = rd.Next(-1, 2);

            curPosition += randomNumber;

            if (randomNumber == 0) {
                Console.WriteLine($"Robot is standing still at position {curPosition}");
            } else if (randomNumber == -1) {
                Console.WriteLine($"Robot is going 1 step backwards at position {curPosition}");
            } else {
                Console.WriteLine($"Robot is going 1 step forwards at position {curPosition}");
            }

            if (curPosition == -10 || curPosition == 10) {
                break;
            }
        }

    }
}
