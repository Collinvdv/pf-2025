namespace MyAppNamespace;

internal class Transaction
{
    // properties
    public DateTime Date { get; set; }
    public String Action { get; set; }

    // constructor 
    public Transaction(string _action)
    {
        this.Action = _action;
        this.Date = DateTime.Now;
    }
}