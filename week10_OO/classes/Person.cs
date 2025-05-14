namespace WeekOO;

internal class Person {
    // properties
    public string Name { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set;}

    // constructor
    public Person(string _name, int _age, Gender _gender = Gender.Male)
    {
        this.Name = _name;
        this.Age = _age;
        this.Gender = _gender;
    }

    // methods
    public void BirthdayTime() {
        this.Age++;
        Console.WriteLine($"Happy b-day, you are now {this.Age} years old");
    }
}