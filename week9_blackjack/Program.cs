namespace MyAppNamespace;

internal class Program
{
    static List<int> pcCards = new List<int>();
    static List<int> userCards = new List<int>();

    private static void Main()
    {
        // Show the commandos
        ShowWelcomeMessage();


        // Ask for this commando
        string commando = Console.ReadLine(); 

        while (commando != "5") {
            // handling the current command
            switch (commando) {
                case "1":
                    StartNewGame();
                    break;
                case "2":
                    ShowHands();
                    break;
                case "3":
                    Hit();
                    break;
                case "4":
                    EndGame();
                    break;
            }

            // Ask a new commando
            commando = Console.ReadLine();
        }
    }

    private static void ShowWelcomeMessage() {
        Console.WriteLine("Welcome to Blackjack!");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Start new game");
        Console.WriteLine("2. Show hands");
        Console.WriteLine("3. Hit (draw card)");
        Console.WriteLine("4. Stand (end turn)");
        Console.WriteLine("5. Exit");
    }

    private static void StartNewGame() {
        Console.WriteLine("Start new game");
        // clear prev cards
        pcCards = new List<int>();
        userCards = new List<int>();

        // 2 cards for the pc , and 2 cards for user
        pcCards.Add(GetRandomCard());
        pcCards.Add(GetRandomCard());
        userCards.Add(GetRandomCard());
        userCards.Add(GetRandomCard());

        Console.WriteLine("Your first cards:");
        PrintList(userCards);
        Console.WriteLine("Total score: " + SumList(userCards));
        Console.WriteLine($"Computer drew {pcCards.Count} cards.");
    }

    private static int GetRandomCard() {
        Random rd = new Random();

        return rd.Next(1, 14);
    }

    private static void ShowHands() {
        Console.WriteLine("Show Hands");
        Console.WriteLine("Your current hand:");

        // loop over the user cards
        PrintList(userCards);
        Console.WriteLine("Total score: " + SumList(userCards));

        // loop over the pc cards (temp)
        Console.WriteLine("Computer current score: " + SumList(pcCards));
    }

    private static void PrintList(List<int> list) {
        foreach(int item in list) {
            Console.WriteLine(item);
        }
    }

    private static int SumList(List<int> list) {
        int sum = 0;
        foreach(int item in list) {
            sum += item;
        }

        return sum;
    }

    private static void Hit() {
        // Get new card and add it to user
        int newCard = GetRandomCard();
        Console.WriteLine("You drew:" + newCard);
        userCards.Add(newCard);

        // Show the total score 
        Console.WriteLine("Total score: " + SumList(userCards));
    }

    private static void EndGame() {
        Console.WriteLine("You stand.");

        // computer logic 
        if (SumList(userCards) > 21) {
            Console.WriteLine("pc wins");
            return;
        }
        
        while (SumList(pcCards) < 17) {
            Console.WriteLine("Computer turn");
            int newCard = GetRandomCard();
            pcCards.Add(newCard);

            Console.WriteLine("Computer drew: " + newCard);
            Console.WriteLine("Computer total score: " + SumList(pcCards));
        }

        int userTotal = SumList(userCards);
        int pcTotal = SumList(pcCards);

        Console.WriteLine($"user has a total of {userTotal}");
        Console.WriteLine($"pc has a total of {pcTotal}");

        if (userTotal > 21) {
            Console.WriteLine("PC wins");
        } else if (pcTotal > 21) {
            Console.WriteLine("User wins");
        } else if (userTotal == pcTotal) {
            Console.WriteLine("It is a tie");
        } else if (userTotal > pcTotal) {
            Console.WriteLine("User wins");
        } else {
            Console.WriteLine("Pc wins");
        }
    }
}