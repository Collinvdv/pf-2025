namespace Pokegame;

internal class Pokemon {
    // properties
    public string Name { get; set; }
    public int Health { get; set; }
    public int Power { get; set; }
    public double CatchRate { get; set; }

    // constructor
    public Pokemon(string _name, int _power, double _catchRate)
    {
        this.Name = _name;
        this.Power = _power;
        this.Health = 100;
        this.CatchRate = _catchRate;
    }
}