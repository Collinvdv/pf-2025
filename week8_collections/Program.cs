namespace MyAppNamespace;

using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

internal class Program
{
    private static void Main() {
    
        // List<string> goats = new List<string>();

        // goats.Add("T-rex");
        // goats.Add("Conny");
        // goats.Add("Clyde");

        // List<string> chickens = new List<string>();
        // chickens.Add("tik");

        // List<string> animals = new List<string>();
        // animals.AddRange(goats);
        // animals.AddRange(chickens);

        // string[] sheeps = {"sheep1", "sheep2"};
        
        
        // animals.AddRange(sheeps);

        // // animals = ReverseList(animals);

        // animals.Reverse();

        // PrintList(animals, "animals");

        // string fn = "collin";
        // fn = fn.ToUpper();
        // Console.WriteLine(fn);

        // string input = "3 -5 0 2 28 -1 -17 288 -99 -4";
        // int[] numbers  = Array.ConvertAll(input.Split(' '), int.Parse);

        // List<int> negNumbers = new List<int>();
        // List<int> posNumbers = new List<int>();

        // foreach(int number in numbers) {
        //     if (number < 0) {
        //         negNumbers.Add(number);
        //     } else {
        //         posNumbers.Add(number);
        //     }
        // }
        
        // PrintList(negNumbers);
        // PrintList(posNumbers);

        // Dictionary<string, int> chickens = new Dictionary<string, int>();

        // // Add an item in a dictionairy
        // chickens.Add("Connie", 2);
        // chickens["Clyde"] = 4;

        // chickens.Remove("Clyde");

        // if ( chickens.ContainsKey("Clyde")) {
        //     chickens["Clyde"] = 40;
        // }

        // chickens.Add("Connie", 5);

        // for (int elementIndex = 0; elementIndex < chickens.Count; elementIndex++) {
        //     Console.WriteLine(chickens.ElementAt(elementIndex).GetType());
        //     string chickenName = chickens.ElementAt(elementIndex).Key;
        //     int eggs = chickens.ElementAt(elementIndex).Value;

        //     Console.WriteLine($"{chickenName} has {eggs} eggs");
        // }

        // foreach (string chickenName in chickens.Keys) {
        //     int eggs = chickens[chickenName];
        //     Console.WriteLine($"{chickenName} has {eggs} eggs");
        // }

        // foreach(int amountOfEggs in chickens.Values) {
        //     Console.WriteLine(amountOfEggs);
        // }

        // foreach(KeyValuePair<string, int> row in chickens) {
        //     string chickenName = row.Key;
        //     int eggs = row.Value;

        //     Console.WriteLine($"{chickenName} has {eggs} eggs");
        // }

        // string input = "Hhello World";
        // Dictionary<char, int> report = new Dictionary<char, int>();

        // foreach(char c in input) {
        //     char cToLower = Char.ToLower(c);
        //     if (report.ContainsKey(cToLower)) {
        //         report[cToLower]++;
        //     } else {
        //         // report.Add(c, 1);
        //         report[cToLower] = 1;
        //     }
        // }

        // foreach(KeyValuePair<char, int> row in report) {
        //     Console.WriteLine($"{row.Key} : {row.Value}");
        // }

        Dictionary<string, List<int>> gradebook = new Dictionary<string, List<int>>();

        int amountOfGrades = 4;

        // populating the dict
        for (int i = 0; i < amountOfGrades; i++) {
            string input = Console.ReadLine(); // Anna 80
            string name = input.Split(' ')[0]; // Anna
            int grade = Convert.ToInt16(input.Split(' ')[1]); // 80

            if (gradebook.ContainsKey(name)) {
                gradebook[name].Add(grade);
            } else {
                gradebook.Add(name, new List<int>());
                gradebook[name].Add(grade);
            }
        }

        // calculate the avg grade per student 
        foreach(var student in gradebook) {
            string name = student.Key;
            List<int> grades = student.Value;

            int total = 0; 
            foreach(int grade in grades) {
                total += grade;
            }

            double avg = total / grades.Count; 

            Console.WriteLine($"{name} and the avarage is {avg}");
        }


    }

    // this code is not needed since method reverse works
    // static List<string> ReverseList(List<string> list) {
    //     List<string> reverseList = new List<string>();

    //     for( int i = list.Count - 1; i >= 0; i--) {
    //         reverseList.Add(list[i]);
    //     }

    //     return reverseList;
    // }

    static void PrintList(List<int> list, string listname = "") {
        Console.WriteLine("-- start list " +  listname + "--");
        foreach(int item in list ) {
            Console.WriteLine(item);
        }
        Console.WriteLine("-- end list --");
    }
}
