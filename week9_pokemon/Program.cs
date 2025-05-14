namespace MyAppNamespace;

using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main() {
        PrintWelcomeMessage();
        ChoosingOptions();
    }

    private static void ChoosingOptions() {
        Dictionary<string, string> pokedex = new Dictionary<string, string>();

        string option = Console.ReadLine(); // 1

        while (option != "5") {
            switch(option) {
                case "1":
                    AddItem(pokedex);
                    break;
                case "2":
                    PrintList(pokedex);
                    break;
                case "3":
                    SearchList(pokedex);
                    break;
                case "4":
                    PrintOptions();
                    break;
            }

            // Ask a new option
            option = Console.ReadLine();
        }

        Console.WriteLine("Goodbye, Trainer!");
    }
    private static void AddItem(Dictionary<string, string> list) {
        Console.WriteLine("Enter Pokémon name:");
        string name = Console.ReadLine(); // 1
        Console.WriteLine("Enter Pokémon type:");
        string type = Console.ReadLine(); // 1
        list.Add(name, type);
    }

    private static void SearchList(Dictionary<string, string> list) {
        Console.WriteLine("Search pokemon");
        Console.WriteLine("Enter Pokémon name to search");
        string searchname = Console.ReadLine();

        if (list.ContainsKey(searchname)) {
            Console.WriteLine($"{searchname} is of type {list[searchname]}.");
        } else {
            Console.WriteLine("Not in the pokedex");
        }
    }
    private static void PrintList(Dictionary<string, string> list) {
        Console.WriteLine("Your collection:");
        foreach(KeyValuePair<string, string> pokerow in list) {
            Console.WriteLine($"{pokerow.Key} - {pokerow.Value}");
        }
        
    }
    private static void PrintWelcomeMessage() {
        Console.WriteLine("Welcome to the Pokedex!");
        
        PrintOptions();
    }

    private static void PrintOptions() {
        Console.WriteLine("1. Choose an option:");
        Console.WriteLine("1. Add Pokémon");
        Console.WriteLine("2. Show all Pokémon");
        Console.WriteLine("3. Search Pokémon");
        Console.WriteLine("4. Show options");
        Console.WriteLine("5. Exit");
    }
}
