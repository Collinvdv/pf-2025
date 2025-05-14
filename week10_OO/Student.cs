namespace WeekOO;
internal class Student {
    // Properties, information (prop + tab)
    public String Name { get; set; }
    private int Age { get; set; }

    // Constructor, asking information when creating an instance (ctor + tab)
    public Student(string _name, int _age)
    {
        this.Name = _name;
        this.Age = _age;
    }

    // Methods
    public void SayHello() {
        Console.WriteLine($"Hi, I am {this.Name} and I am {this.Age} years old.");
    }
}
