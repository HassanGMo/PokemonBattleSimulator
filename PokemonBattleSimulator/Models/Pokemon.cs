namespace PokemonBattleSimulator.Models
{
    public class Pokemon
    {
        // This stores all the Pokemoms information
        public int PokemonID { get; set; }
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";
        public int Attack { get; set; }
        public int MaxHP { get; set; }
        public string ImageFile { get; set; } = "";

        // This stores the current health of pokemons during the battle
        public int CurrentHP { get; set; }
    }
}