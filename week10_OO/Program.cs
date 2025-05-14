namespace WeekOO;

using System;

internal class Program
{
    private static void Main() {
        // Students
        Student student1 = new Student("Youssef", 20);
        Student student2 = new Student("Regina", 19);

        // Teachers
        Teacher teacher1 = new Teacher("Mr. Van der Vorst", 34, "u38595");
        Teacher teacher2 = new Teacher("Mr. Awesome", 34);
        Teacher teacher3 = new Teacher("Mrs. Old", 70);

        // Courses
        Course pf = new Course("xxx", "programming fundamentals", teacher1);
        Course beingAwesome = new Course("xxo", "How to be awesome in 13 weeks", teacher2);

        student1.Subscribe(pf);
        student1.Subscribe(beingAwesome);
        student2.Subscribe(pf);

        student1.PrintCourses();

    }
}
