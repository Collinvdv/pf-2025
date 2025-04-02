namespace MyAppNamespace;

using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main()
    {
        // Recap: writing
        // O: ADD, STOP
        // I: ADD 
        // I: pigeon
        // O: pigeon has been added to birds.txt 
        // I: ADD
        // I: hawk 
        // O: hawk has been added to birds.txt
        // I: STOP 
        // O: STOP THE APPLICATION
        // StreamWriter streamBird = File.AppendText("birds.txt");

        // Console.WriteLine("ADD, STOP");

        // string commando = Console.ReadLine();

        // while (commando.ToLower() != "stop") {
        //     // do something with the command 
        //     switch (commando.ToLower()) {
        //         case "add":
        //             string bird = Console.ReadLine();
        //             streamBird.WriteLine(bird);
        //             break;
        //         default: 
        //             Console.WriteLine("Command is not known");
        //             break;
        //     }

        //     // Ask the new command
        //     commando = Console.ReadLine();
        // }

        // streamBird.Close();

        // Recap: reading: option 1 read the full document
        // StreamReader readerBirds = File.OpenText("birds.txt");
        // string birdsText = readerBirds.ReadToEnd();
        // Console.WriteLine(birdsText);

        // option 2 read the fulle document 
        // string birdsText = File.ReadAllText("birds.txt");
        // Console.WriteLine(birdsText);

        // option 3 read line by line
        // StreamReader readerBirds = File.OpenText("birds.txt");

        // string line = readerBirds.ReadLine();

        // while (line != null) {
        //     Console.WriteLine("Line is: " + line);

        //     line = readerBirds.ReadLine();
        // }

        // readerBirds.Close();

        // option 3 read line by line
        // string[] lines = File.ReadAllLines("birds.txt");

        // // for (int i = 0; i < lines.Length; i++) {
        // //     Console.WriteLine("Line " + (i + 1) + " " + lines[i]);
        // // }

        // foreach(string line in lines) {
        //     Console.WriteLine(line);
        // }

        // Read birds.txt 
        // O: What is the first letter of the bird? 
        // I: P
        // O: Pigeon
        // O: Pigeon

        // string[] lines = File.ReadAllLines("birds.txt");
        // char givenChar = Convert.ToChar(Console.Read());
        
        // foreach (string line in lines) {
        //     if (line[0] == givenChar) {
        //         Console.WriteLine(line);
        //     }
        // }

        
        // string text = File.ReadAllText("Harry Potter and the Sorcerer.txt");
        // Regex rx = new Regex("Harry");
        // MatchCollection matches = rx.Matches(text);
        // Console.WriteLine(matches.Count + " matches found!");

        // Regex rx = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");
        // string password = "cOll1n!aaaaa";
        // Boolean isValid = rx.IsMatch(password); 
        // Console.WriteLine(isValid);

        // BE BACK AT 10:05
        // string numberStr= Console.ReadLine();
        // int number;
        // Boolean isNumber = int.TryParse(numberStr, out number);

        // if (isNumber){
        //     number *= 2;
        //     Console.WriteLine(number);
        // } else {
        //     Console.WriteLine("Can not convert");
        // }

        // string fileName = Console.ReadLine();

        // Boolean isFileExisting = File.Exists(fileName);
        // while (!isFileExisting) {
        //     Console.WriteLine("Sorry, file does not exists, give me a new one");
    
        //     fileName = Console.ReadLine();
        //     isFileExisting = File.Exists(fileName);
        // }
        
        // string[] lines = File.ReadAllLines(fileName);
        // Console.WriteLine(lines.Length);

        // try {
        //     string fileName = Console.ReadLine();

        //     string fullText = File.ReadAllText(fileName);
        // } catch (FileNotFoundException) {
        //     Console.WriteLine("File was not found");
        // } catch(Exception e) {
        //     Console.WriteLine("Something went wrong");
        //     Console.WriteLine(e.Message);
        // }

        string input = "3 collin 0 2 28 -1 -17 288 -99 -4";
        string[] numbersAsString = input.Split(' ');
        string negativeNumbers = "";
        string positiveNumbers = "";
        string notNumbers = "";

        // Loop 
        // foreach (string numberAsString in numbersAsString) {

        //     int number;
        //     Boolean isNumber = int.TryParse(numberAsString, out number);

        //     if (isNumber) {
        //         if (number >= 0) {
        //             positiveNumbers += number + " ";
        //         } else {
        //             negativeNumbers += number + " ";
        //         }
        //     } else {
        //         notNumbers += numberAsString + " "; 
        //     }
        // }

        foreach (string numberAsString in numbersAsString) {
            try {
                int number = Convert.ToInt16(numberAsString);

                if (number >= 0) {
                    positiveNumbers += number + " ";
                } else {
                    negativeNumbers += number + " ";
                }
            } catch(FormatException) {
                Console.WriteLine("Not a number");
            }
        }
        
        Console.WriteLine(positiveNumbers);
        Console.WriteLine(negativeNumbers);
        

    }
}
