namespace MyAppNamespace;

internal class Program
{
    public static List<Bankaccount> Bankaccounts { get; set; } = new List<Bankaccount>();
    private static void Main()
    {
        // Add 2 static bankaaccount
        Bankaccount b1 = new Bankaccount("collin", 0);
        Bankaccount b2 = new Bankaccount("lisa", 1000);
        Bankaccounts.Add(b1);
        Bankaccounts.Add(b2);

        string commando = Console.ReadLine();

        while (commando != "8")
        {
            switch (commando)
            {
                case "1":
                    AddBankaccount();
                    break;
                case "2":
                    Transfer();
                    break;
                case "3":
                    Withdraw();
                    break;
                case "4":
                    Deposit();
                    break;
                case "5":
                    CheckBalance();
                    break;
                case "6":
                    CheckTransactions();
                    break;
                case "7":
                    ListBankaccounts();
                    break;
            }

            commando = Console.ReadLine();
        }
    }

    public static void CheckBalance()
    {
        Bankaccount b = SelectBankAccount();
        b.CheckBalance();
    }

    public static void Transfer()
    {
        Bankaccount sender = SelectBankAccount();
        Bankaccount receiver = SelectBankAccount();

        Console.WriteLine("What is the amount to transfer");
        double amount = Convert.ToDouble(Console.ReadLine());

        sender.Transfer(receiver, amount);
    }

    public static void Deposit()
    {
        Bankaccount b = SelectBankAccount();
        Console.WriteLine("What is the amount that you want to deposit?");
        double amount = Convert.ToDouble(Console.ReadLine());
        b.Deposit(amount);
    }

    public static void Withdraw()
    {
        Bankaccount b = SelectBankAccount();
        Console.WriteLine("What is the amount that you want to withdraw?");
        double amount = Convert.ToDouble(Console.ReadLine());
        b.Withdraw(amount);
    }

    public static void CheckTransactions()
    {
        Bankaccount b = SelectBankAccount();
        b.ListTransactions();
    }

    public static Bankaccount SelectBankAccount()
    {
        Console.WriteLine("Pick a bankaccount");
        ListBankaccounts();

        int bankaccountIndex = Convert.ToInt16(Console.ReadLine());

        return Bankaccounts[bankaccountIndex];

    }
    public static void ListBankaccounts()
    {
        foreach (Bankaccount b in Bankaccounts)
        {
            Console.WriteLine(b.GetName());
        }
    }
    public static void AddBankaccount()
    {
        // Asking for some input
        Console.WriteLine("What is the name of the Account?");
        string name = Console.ReadLine();
        Console.WriteLine("What is the amount you already want to add?");
        double amount = Convert.ToDouble(Console.ReadLine());

        // Creating the bankaccount
        Bankaccount b = new Bankaccount(name, amount);
        Bankaccounts.Add(b);
    }
}
