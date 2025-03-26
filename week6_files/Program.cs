namespace MyAppNamespace;

using System;
using System.IO;

internal class Program
{
    private static void Main()
    {
        //     // StreamWriter stream = File.CreateText("bs2.txt"); // CreateText() always going to create a new file;
        //    StreamWriter stream = File.AppendText("bs2.txt"); // CreateText() always going to create a new file;
        //    stream.WriteLine("Lisa");
        //    stream.Close();

        // BS seminar guest files
        // O: what is the event? 
        // I: ai
        // O: we are going to use the ai.txt file
        // O: Now let us add the guest, say stop to exit the program
        // I: Lisa 
        // O: Lisa is been added to ai.txt
        // I: Renske
        // O: Renske is been added to ai.txt
        // I: STOP
        // O: exit the program

        // Ask for the event name
        // Console.WriteLine("What is the event?");
        // string eventName = Console.ReadLine();

        // // Create/append a file for this event
        // string filename = eventName + ".txt";
        // StreamWriter eventStream = File.AppendText(filename);
        // Console.WriteLine($"we are going to use the {filename} file");

        // // Add logging system
        // Console.WriteLine("Now let us add the guest, say stop to exit the program");

        // string commando = Console.ReadLine();

        // while (commando.ToLower() != "stop") {
        //     eventStream.WriteLine(commando);
        //     Console.WriteLine("Added name" + commando);
        //     commando = Console.ReadLine();
        // }

        // eventStream.Close();

        // Creating file based on team 1 and team 2
        // Console.WriteLine("Welcome to my football program");
        // Console.WriteLine("What is name of team 1?");
        // string team1 = Console.ReadLine(); // I: Belgium
        // Console.WriteLine("What is name of team 2?");
        // string team2 = Console.ReadLine(); // I: France

        // // Create a file if exists 
        // string filename = $"{team1.ToLower()}-{team2.ToLower()}.txt";

        // if (File.Exists(filename)) {
        //     File.Delete(filename);
        // } 

        // StreamWriter stream = File.AppendText(filename);
        // stream.WriteLine($"Team 1: {team1}");
        // stream.WriteLine($"Team 2: {team2}");

        // // creating the logging system 
        // string commando = Console.ReadLine();

        // while (commando.ToLower() != "stop") {
        //     switch (commando.ToLower()) {
        //         case "goal":
        //             Console.WriteLine("Which team?");
        //             string teamChoice = Console.ReadLine(); // 1 or 2 
        //             string player = Console.ReadLine(); 

        //             if (teamChoice == "1") {
        //                 stream.WriteLine($"{player}{team1} has scored ");
        //             } else {
        //                 stream.WriteLine($"{player}{team2} has scored ");
        //             }
        //             break;
        //         default: 
        //             Console.WriteLine("Sayyyy whuuuut???");
        //             break;
        //     }

        //     // ask a new commando
        //     commando = Console.ReadLine();
        // }

        // O: commands [goal, stop]
        // I: goal
        // O: Which team?
        // I: 1
        // O: Who scored?
        // I: Lukaku
        
        // I: stop
        // O: belgium-france.txt has created

        /*
            Team 1: Belgium
            Team 2: France 
            Lukaku(Belgium) has scored 
        */

        //    stream.Close();


        // // Reading a file as full text: approach 1 
        // StreamReader reader = File.OpenText("students.txt");
        // string fullText = reader.ReadToEnd();
        // Console.WriteLine(fullText);

        // // Reading a file as full text: approxt 2 
        // string fullText2 = File.ReadAllText("students.txt");

        // // Reading a file as an array string: approach 1 
        // string[] lines = File.ReadAllLines("students.txt");

        // foreach(string line in lines) {
        //     Console.WriteLine(line);
        // }

        // Reading a file as an array string: approach 2 
        // StreamReader reader = File.OpenText("students.txt"); 

        // string line = reader.ReadLine();
        // Console.WriteLine(line);

        // line = reader.ReadLine();

        // while (line != null) {
        //     Console.WriteLine(line); 

        //     line = reader.ReadLine();
        // }

        // reader.Close();

        // Objective: Count the number of lines in a file.
        // O: Enter filename:
        // I: Harry Potter and the Sorcerer.txt
        // O: Total lines: 653

        // 
        Console.WriteLine("Enter filename:");
        string filename = "Harry Potter and the Sorcerer.txt";

        Console.WriteLine("Give a word");
        string word = "Harry";

        if (!File.Exists(filename)) {
            Console.WriteLine("Not existing");
        } else {
            string[] lines = File.ReadAllLines(filename);

            int counterPhrase = 0;
            foreach (string line in lines) {
                if (line.ToLower().Contains(word.ToLower())) {
                    counterPhrase++;
                }
            }
            Console.WriteLine($"Total lines: "+ lines.Length);
            Console.WriteLine($"Total lines with the word {word}: {counterPhrase}");

            for(int lineIndex = 0 ; lineIndex < lines.Length; lineIndex++) {
                if (lines[lineIndex].Contains(word.ToUpper())) {
                    Console.WriteLine(lineIndex);
                    Console.WriteLine(lines[lineIndex]);
                }
            }
        }

        // Objective: Count the number of lines in a file.
        // O: Enter filename:
        // I: Harry Potter and the Sorcerer.txt
        // O: Give a word
        // I: Harry
        // O: Harry appears in 300 lines
    }
}
