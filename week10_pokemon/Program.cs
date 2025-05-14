namespace Pokegame;

internal class Program
{
    private static void Main()
    {
        // Pokemons
        Pokemon pokemon1 = new Pokemon("Pikachu", 100, 0.5);
        Pokemon pokemon2 = new Pokemon("Charizard", 200, 0.1);
        Pokemon pokemon3 = new Pokemon("Raichu", 300, 0.3);
        Pokemon pokemon4 = new Pokemon("Snorlax", 400, 1.0);

        // Pokeballs
        Pokeball ball1 = new Pokeball("Normal", 0.2);
        Pokeball ball2 = new Pokeball("Special", 0.9);
        Pokeball ball3 = new Pokeball("Advanced", 0.7);
        Pokeball ball4 = new Pokeball("Master", 1);

        // Trainers 
        Trainer ash = new Trainer("Ash");
        Trainer brook = new Trainer("Brook");
        Trainer misty = new Trainer("Misty");

        // Add pokebals 
        ash.AddPokeball(ball1);
        ash.AddPokeball(ball2);
        brook.AddPokeball(ball3);
        misty.AddPokeball(ball4);
        ash.AddPokeball(ball3);

        ash.ListPokeballs();
    }
}
