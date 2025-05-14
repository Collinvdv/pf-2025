namespace WeekOO;
internal class Student: Person {
    // Properties, information (prop + tab)

    // Constructor, asking information when creating an instance (ctor + tab)
    public Student(string _name, int _age) : base(_name, _age)
    {
    }

    // Methods
    public void SayHello() {
        Console.WriteLine($"Hi, I am {this.Name} and I am {this.Age} years old.");
    }
}
