namespace WeekOO;

internal class Teacher:Person {
    // Properties + prop tab
    public String T_Nbr { get; set; }

    // Constructor, what information do you need to create an instancte
    public Teacher(string _name, int _age, string _t_nbr = "xxxx") : base(_name, _age)
    {
        this.T_Nbr = _t_nbr;
    }

    // Methods 
    public void Teach() {
        if (this.Age > 67) {
             Console.WriteLine($"{this.Name} is retired.");
        } else {
            Console.WriteLine($"{this.Name} is teaching.");
        }
    }
}