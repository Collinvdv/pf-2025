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

    // Methods 
    public void AddPokeball(Pokeball _ball) {
        if (_ball.IsOwned) {
            Console.WriteLine(" YOU CAN NOT STEAL THE BALL!");
        } else {
            this.Pokeballs.Add(_ball);
            _ball.IsOwnedByTrainer();
        }
    }

    public void ListPokeballs () {
        foreach(Pokeball ball in Pokeballs) {
            Console.WriteLine(ball.Name);
        }
    }
}