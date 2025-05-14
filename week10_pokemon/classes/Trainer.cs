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
            Console.WriteLine($"{this.Name} CAN NOT STEAL THE BALL!");
        } else {
            Console.WriteLine($"{this.Name} added the ball {_ball.Name}");
            this.Pokeballs.Add(_ball);
            _ball.IsOwnedByTrainer();
        }
    }

    public void ListPokeballs () {
        foreach(Pokeball ball in Pokeballs) {
            Console.WriteLine(ball.Name);
        }
    }

    public bool CatchPokemon(Pokemon pokemon) {
        if (Pokeballs.Count == 0) {
            Console.WriteLine($"{this.Name} has no Pokeballs left!");
            return false;
        }

        Pokeball ball = Pokeballs[0];
        Console.WriteLine($"{this.Name} throws a {ball.Name} ball at {pokemon.Name}!");

        Random random = new Random();
        double catchChance = ball.CatchRate + pokemon.CatchRate;
        double randomValue = random.NextDouble();

        Pokeballs.RemoveAt(0);

        if (randomValue <= catchChance) {
            this.Pokemons.Add(pokemon);
            Console.WriteLine($"{pokemon.Name} was caught!");
            return true;
        } else {
            Console.WriteLine($"{pokemon.Name} broke free!");
            return false;
        }
    }
}