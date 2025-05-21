namespace MyAppNamespace;

internal class Bankaccount
{
    // Properties
    private string Name { get; set; }
    private double Balance { get; set; }
    public List<Transaction> Transactions { get; set; }

    // Constructor 
    public Bankaccount(string _name)
    {
        this.Name = _name;
        this.Balance = 0;
        this.Transactions = new List<Transaction>();
    }

    public Bankaccount(string _name, double _balance)
    {
        this.Name = _name;
        this.Balance = _balance;
        this.Transactions = new List<Transaction>();
    }

    // Methods 
    public void CheckBalance()
    {
        Console.WriteLine($"Balance on account {this.Name} is {this.Balance}");
    }

    public void Deposit(double _amount)
    {
        this.Balance += _amount;
        this.CheckBalance();

        Transaction t = new Transaction($"[DEPOSIT] {_amount}");
        this.Transactions.Add(t);
    }

    public void Withdraw(double _amount)
    {
        // Checking if negative 
        if (_amount < 0)
        {
            Console.WriteLine("Negativa amount");
            return;
        }

        // Checking if I can go lower
        double futureBalance = this.Balance - _amount;
        if (futureBalance < 0)
        {
            Console.WriteLine("Sorry not possible");
            return;
        }

        // Changing the amount
        this.Balance -= _amount;
        this.CheckBalance();

        Transaction t = new Transaction($"[WITHDRAW] {_amount}");
        this.Transactions.Add(t);
    }

    public void Transfer(Bankaccount _receiver, double _amount)
    {
        this.Balance -= _amount;
        _receiver.Balance += _amount;

        this.CheckBalance();
        _receiver.CheckBalance();

        Transaction t1 = new Transaction($"[TRANSFERED MONEY TO {_receiver.Name}] {_amount}");
        this.Transactions.Add(t1);

        Transaction t2 = new Transaction($"[RECEIVED MONEY FROM {this.Name}] {_amount}");
        _receiver.Transactions.Add(t2);
    }

    public void ListTransactions()
    {
        Console.WriteLine("------ List of transactions -------");

        foreach (Transaction t in this.Transactions)
        {
            Console.WriteLine($"{t.Date.ToString()} : {t.Action}");
        }
    }

    public string GetName()
    {
        return this.Name;
    }
}