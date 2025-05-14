using System.Security.Cryptography;

namespace WeekOO;
internal class Student: Person {
    // Properties, information (prop + tab)
    public List<Course> Courses { get; set; }

    // Constructor, asking information when creating an instance (ctor + tab)
    public Student(string _name, int _age) : base(_name, _age)
    {
        this.Courses = new List<Course>();
    }

    // Methods
    public void SayHello() {
        Console.WriteLine($"Hi, I am {this.Name} and I am {this.Age} years old.");
    }

    public void Subscribe(Course course) {
        this.Courses.Add(course);
    }

    public void PrintCourses() {
        foreach(Course course in this.Courses) {
            Console.WriteLine(course.Name);
        }
    }
}
