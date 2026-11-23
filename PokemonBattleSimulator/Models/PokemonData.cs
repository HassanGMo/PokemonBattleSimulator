using System.Collections.Generic;

namespace PokemonBattleSimulator.Models
{
    public class PokemonData
    {
        // Stores all six Pokemons including all their stats and imageFile
        public static List<Pokemon> PokemonList = new List<Pokemon>
        {
            new Pokemon
            {
                PokemonID = 1,
                Name = "Charmander",
                Type = "Fire",
                Attack = 15,
                MaxHP = 100,
                CurrentHP = 100,
                ImageFile = "charmander.png"
            },

            new Pokemon
            {
                PokemonID = 2,
                Name = "Squirtle",
                Type = "Water",
                Attack = 14,
                MaxHP = 110,
                CurrentHP = 110,
                ImageFile = "squirtle.png"
            },

            new Pokemon
            {
                PokemonID = 3,
                Name = "Bulbasaur",
                Type = "Grass",
                Attack = 13,
                MaxHP = 115,
                CurrentHP = 115,
                ImageFile = "bulbasaur.png"
            },

            new Pokemon
            {
                PokemonID = 4,
                Name = "Pikachu",
                Type = "Electric",
                Attack = 18,
                MaxHP = 90,
                CurrentHP = 90,
                ImageFile = "pikachu.png"
            },

            new Pokemon
            {
                PokemonID = 5,
                Name = "Eevee",
                Type = "Normal",
                Attack = 14,
                MaxHP = 95,
                CurrentHP = 95,
                ImageFile = "eevee.png"
            },

            new Pokemon
            {
                PokemonID = 6,
                Name = "Jigglypuff",
                Type = "Fairy",
                Attack = 10,
                MaxHP = 120,
                CurrentHP = 120,
                ImageFile = "jigglypuff.png"
            }
        };
    }
}