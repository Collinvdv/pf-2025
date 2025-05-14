namespace WeekOO;

internal class Teacher {
    // Properties + prop tab
    public String Name { get; set; }
    public int Age { get; set; }
    public String T_Nbr { get; set; }

    // Constructor, what information do you need to create an instancte
    public Teacher(string _name, int _age, string _t_nbr = null)
    {
        this.Name = _name;
        this.Age = _age;
        this.T_Nbr = _t_nbr;
    }

    public Teacher(string _name) {
        this.Name = _name;
    }

    // Methods 
    public void Teach() {
        Console.WriteLine($"{this.Name} is teaching.");
    }
}