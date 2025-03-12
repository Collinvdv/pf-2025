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

        // // Creating an array with a specific length
        // int amountOfGrades = Convert.ToInt16(Console.ReadLine()); // 4
        // int[] grades = new int[amountOfGrades];

        // // Populating
        // for(int i = 0; i < grades.Length; i++) {
        //     grades[i] = Convert.ToInt16(Console.ReadLine());
        // }

        // // Output
        // foreach (int grade in grades) {
        //     Console.WriteLine(grade);
        // }

        // int numberOfElements = Convert.ToInt16(Console.ReadLine());
        // int[] numbers = new int[numberOfElements];

        // // populating
        // for (int i = 0; i < numbers.Length; i++) {
        //     numbers[i] = Convert.ToInt16(Console.ReadLine());
        // }

        // // sum
        // int sum = 0;
        // foreach(int number in numbers) {
        //     sum+=number;
        // }
        // Console.WriteLine(sum);

        // string goats = "t-rex connie clyde";
        // Console.WriteLine(goats[0]);
        // string[] goatsArray = goats.Split(' ');
        
        // Students
        // Console.WriteLine("Enter number of students: ");
        // int nbrOfStudents = Convert.ToInt16(Console.ReadLine());

        // Console.WriteLine("Enter number of subjects: ");
        // int nbrOfSubjects = Convert.ToInt16(Console.ReadLine());

        // double [,] gradebook = new double[nbrOfStudents, nbrOfSubjects];

        // // population
        // for (int st = 0; st < gradebook.GetLength(0); st++) {
        //     for (int su = 0; su < gradebook.GetLength(1); su++) {
        //         Console.WriteLine($"Enter grade for Student {st}, Subject {su}: ");
        //         gradebook[st,su] = Convert.ToDouble(Console.ReadLine());
        //     }
        // }

        // // Average per student
        // for (int st = 0; st < gradebook.GetLength(0); st++) {
        //     double studentSum = 0;
        //     for (int su = 0; su < gradebook.GetLength(1); su++) {
        //         studentSum += gradebook[st,su];
        //     }

        //     double stAvg = studentSum / gradebook.GetLength(1);
        //     Console.WriteLine($"Student {st} average: {stAvg}");
        // }


        // int[][] gradebook = new int[2][];

        // gradebook[0] = new int[3];
        // gradebook[1] = new int[2];

        // // student 1
        // gradebook[0][0] = 85;
        // gradebook[0][1] = 78;
        // gradebook[0][2] = 92;

        // // student 2
        // gradebook[1][0] = 88;
        // gradebook[1][1] = 75;

        // for (int studentIndex = 0; studentIndex < gradebook.Length; studentIndex++) {
        //     int amountOfGrades = gradebook[studentIndex].Length;

        //     double totalSumOfGrades = 0;
        //     for (int gradesIndex = 0; gradesIndex < amountOfGrades; gradesIndex++) {
        //         totalSumOfGrades += gradebook[studentIndex][gradesIndex];
        //     }

        //     double avgStudent = totalSumOfGrades / amountOfGrades;
        //     Console.WriteLine($"Student {studentIndex} has an average of {avgStudent}");
        // }

        // int[] grades =  {5, 10, 15, 20};
        // Console.WriteLine(grades[^2]);

        int[][] temperatures = {
            new int[] {3, 5, 7},      // January
            new int[] {1, 4},      // February
            new int[] {6, 10, 12},    // March
            new int[] {9, 14, 15},    // April
            new int[] {12, 18, 20},   // May
            new int[] {15, 22, 25},   // June
            new int[] {18, 25, 30},   // July
            new int[] {17, 23, 28},   // August
            new int[] {13, 19, 24, 40},   // September
            new int[] {9, 14, 18},    // October
            new int[] {5, 10, 12},    // November
            new int[] {2, 6, 9}       // December
        };

        for (int monthIndex = 0; monthIndex < temperatures.Length; monthIndex++) {
            Console.WriteLine(monthIndex + " : " + temperatures[monthIndex].Length);
            int sumTemp = 0;
            double amountOfTemp = temperatures[monthIndex].Length;
            for (int temperatureIndex = 0 ; temperatureIndex< amountOfTemp; temperatureIndex++) {
                sumTemp += temperatures[monthIndex][temperatureIndex];
            }

            double avgTemp  = sumTemp / amountOfTemp;

            string[] months = {
                "January", "February", "March", "April",
                "May", "June", "July", "August",
                "September", "October", "November", "December"
            };

            Console.WriteLine(months[monthIndex] + " " + avgTemp);
        }
    }
}
