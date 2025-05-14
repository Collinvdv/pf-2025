namespace WeekOO;

internal class Course {
    // properties
    public string ID { get; set; }
    public string Name { get; set; }
    public Teacher CourseTeacher { get; set; }

    // constructor
    public Course(string _id, string _name, Teacher _teacher = null)
    {
        this.ID = _id;
        this.Name = _name;
        this.CourseTeacher = _teacher;
    }

    // Methods
}