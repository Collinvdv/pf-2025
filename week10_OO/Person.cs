namespace WeekOO;

internal class Person {
    // properties
    public string Name { get; set; }
    public int Age { get; set; }

    // constructor
    public Person(string _name, int _age)
    {
        this.Name = _name;
        this.Age = _age;
    }

    // methods
    public void BirthdayTime() {
        this.Age++;
        Console.WriteLine($"Happy b-day, you are now {this.Age} years old");
    }
}