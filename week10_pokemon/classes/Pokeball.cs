namespace Pokegame;

internal class Pokeball {
    // properties
    public string Name { get; set; }
    public double CatchRate { get; set; }

    // constructor
    public Pokeball(string _name, double _catchRate)
    {
        this.Name = _name;
        this.CatchRate = _catchRate;
    }
}