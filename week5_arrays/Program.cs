namespace MyAppNamespace;

internal class Program
{
    private static void Main()
    {
        // loops
        // start; expression; step
        // for (int i = 1; i <= 10; i++) {
        //     Console.WriteLine(i);

        //     if (i == 5) {
        //         break;
        //     }
        // }
        
        // secretWord = "banana"
        // string secretWord = Console.ReadLine(); 

        // while (secretWord != "banana") {
        //     Console.WriteLine("Not the secret password");

        //     secretWord = Console.ReadLine();
        // }
        
        // while (true) {
        //     if (secretWord == "banana") {
        //         break;
        //     } else {
        //         Console.WriteLine("Not the secret password");
        //         secretWord = Console.ReadLine();
        //     }
        // }
        
        // Objective: Simulate ATM withdrawal with limited attempts using a while loop.
        // O: COMMANDS [ADD, WITHDRAW, CHECK, STOP]
        // I: ADD
        // I: 300
        // O: Current balance is 300
        // I: ADD
        // I: 200
        // O: Current balance is 500
        // I: CHECK
        // O: Current balance is 500
        // I: WITHDRAW
        // I: 100
        // O: Current balance is 400

        // Show the commands
        // Console.WriteLine("COMMANDS [ADD, WITHDRAW, CHECK, STOP]");

        // string commando = Console.ReadLine().ToUpper();
        // int balance = 0;

        // while (commando != "STOP") {
        //     // Pick the correct commando, and do some logic 
        //     switch (commando) {
        //         case "ADD":
        //             int addAmount = Convert.ToInt16(Console.ReadLine());
        //             balance += addAmount;
        //             Console.WriteLine($"Current balance is {balance}");
        //             break;
        //         case "CHECK":
        //             Console.WriteLine($"Current balance is {balance}");
        //             break;
        //         case "WITHDRAW":
        //             int withdrawAmount = Convert.ToInt16(Console.ReadLine());
        //             balance -= withdrawAmount;
        //             Console.WriteLine($"Current balance is {balance}");
        //             break;
        //         default: 
        //             Console.WriteLine("I don't know the command");
        //             break;
        //     }
        //     // Ask for a new commando
        //     commando = Console.ReadLine().ToUpper();


        // }

        // string[] goats = {"T-rex", "Connie", "Clyde", "Tjersnobyl goat"};

        // for (int i = 0; i < goats.Length; i++ ) {
        //     Console.WriteLine(goats[i]);
        // }

        // Creating an array with a specific length
        int amountOfGrades = Convert.ToInt16(Console.ReadLine()); // 4
        int[] grades = new int[amountOfGrades];

        // Populating
        for(int i = 0; i < grades.Length; i++) {
            grades[i] = Convert.ToInt16(Console.ReadLine());
        }

        // Output
        foreach (int grade in grades) {
            Console.WriteLine(grade);
        }


    }
}
