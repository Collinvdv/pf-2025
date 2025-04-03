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

        // string input = "3 collin 0 2 28 -1 -17 288 -99 -4";
        // string[] numbersAsString = input.Split(' ');
        // string negativeNumbers = "";
        // string positiveNumbers = "";
        // string notNumbers = "";

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

        // foreach (string numberAsString in numbersAsString) {
        //     try {
        //         int number = Convert.ToInt16(numberAsString);

        //         if (number >= 0) {
        //             positiveNumbers += number + " ";
        //         } else {
        //             negativeNumbers += number + " ";
        //         }
        //     } catch(FormatException) {
        //         Console.WriteLine("Not a number");
        //     }
        // }
        
        // Console.WriteLine(positiveNumbers);
        // Console.WriteLine(negativeNumbers);


        // 5
        // 0 ~ ~ ~ 1 zero 4 tilde
        // 0 0 ~ ~ ~ 2 zero 3 tilde 
        // 0 0 0 ~ ~ 3 zero 2 tilde
        // 0 0 0 0 ~ 4 zero 1 tilde
        // 0 0 0 0 0 5 zero 0 tilde

        // int amountOfRows = Convert.ToInt16(Console.ReadLine());
        // for (int i = 1; i <= amountOfRows; i++) {
        //     int amountOfZeros = i;
        //     int amountOfTildes = amountOfRows - i;

        //     string row = ""; 

        //     // Zero 
        //     for (int zero = 1; zero <= amountOfZeros; zero++) {
        //         row += "0";
        //     }

        //     // Tildes
        //     for (int tilde = 1; tilde <= amountOfTildes; tilde++) {
        //         row += "~";
        //     }

        //     // Reverse row 
        //     string rowReverse = "";

        //     for (int charIndex = row.Length -1; charIndex >= 0; charIndex--) {
        //         rowReverse += row[charIndex];
        //     }

        //     Console.WriteLine(row + rowReverse);
        // }

        // amount of rows = 5 
        // 0 ~ ~ ~ ~ ~ ~ ~ ~ 0 zero 2 tildes 8 
        
        // 0 0 ~ ~ ~ ~ ~ ~ 0 0 zero 4 tildes 6
        // 2 zeros 6 tildes 2 zero 
        // 
        // 0 0 0 ~ ~ ~ ~ 0 0 0 zero 6 tildes 4
        // 0 0 0 0 ~ ~ 0 0 0 0 zero 8 tildes 2
        // 0 0 0 0 0 0 0 0 0 0 zero 10 tildes 0

        // int amountOfRows = Convert.ToInt16(Console.ReadLine()); 
        // int amountOfColumns = amountOfRows * 2; 

        // for (int x = 2; x <= amountOfColumns; x+=2) {
        //     int amountOfZeros = x;
        //     int amountOfTildes = amountOfColumns - x;

        //     string row = "";
        //     // initial zeros 
        //     for (int initialZero = 0; initialZero < (amountOfZeros / 2); initialZero++) {
        //         row += "0";
        //     }

        //     // Tilde
        //     for (int tilde = 0; tilde < amountOfTildes; tilde++) {
        //         row += "~";
        //     }

        //     // initial zeros 
        //     for (int endZero = 0; endZero < (amountOfZeros / 2); endZero++) {
        //         row += "0";
        //     }

        //     Console.WriteLine(row);
        // }

        // I: 4
        //*
        //**
        //***
        //****
        
        // string input = Console.ReadLine();
        // int numberOfRows;
        // Boolean isNumber = int.TryParse(input, out numberOfRows);

        // if (isNumber) {
        //     for (int row = 1; row <= numberOfRows; row++) {
        //         string output = ""; 

        //         for (int column = 0; column < row; column ++) {
        //             output += "*";
        //         }
        //         Console.WriteLine(output);
        //     }
        // } else {
        //     Console.WriteLine("No number validation");
        // }


        // 111001 = 57
        // 2 ^ 5 = 32 * 1 = 32 -> charIndex 0, powerTo = 5
        // 2 ^ 4 = 16 * 1 = 16
        // 2 ^ 3 = 8 * 1 = 8
        // 2 ^ 2 = 4 * 0 = 0
        // 2 ^ 1 = 2 * 0 = 0
        // 2 ^ 0 = 1 * 1 = 1
        // 57 (32 + 16 + 8 + 1)
        // I only want to this when the binary code has only 0 and 1 init (so maybe just a regex)


        // 1101, 4 numbers 

        // 2 ^ 3 = 8  * 1 = 8 
        // 2 ^ 2 = 4  * 1 = 4
        // 2 ^ 1 = 2 * 0 = 0 
        // 2 ^ 0 = 1  * 1  = 1
        // 1101 = 13;


        // I = 1101 
        // O = 13

        // I = 1404
        // O = not a binary code

        string binaryCode = "1411001"; 
        Regex rx = new Regex(@"^[01]+$");

        if (rx.IsMatch(binaryCode)) {
            double result = 0;

            for (int i = 0; i < binaryCode.Length; i++) {
                // 2 ^ 3
                if (binaryCode[i] == '1') {
                    double number = Math.Pow(2, (binaryCode.Length - 1) - i);
                    result += number;
                }
            }

            Console.WriteLine(result);
        } else {
            Console.WriteLine("Not a binary number");
        }

    }
}
