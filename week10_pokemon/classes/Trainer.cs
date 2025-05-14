namespace Pokegame;

internal class Trainer {
    // Properties
    public String Name { get; set; }
    public List<Pokemon> Pokemons {get; set;}
    public List<Pokeball> Pokeballs {get; set;}

    // Constructor
    public Trainer(string _name)
    {
        this.Name = _name;
        this.Pokemons = new List<Pokemon>();
        this.Pokeballs = new List<Pokeball>();
    }
}