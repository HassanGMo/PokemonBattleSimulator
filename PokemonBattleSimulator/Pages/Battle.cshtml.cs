using Microsoft.AspNetCore.Mvc.RazorPages;
using PokemonBattleSimulator.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace PokemonBattleSimulator.Pages
{
    public class BattleModel : PageModel
    {
        // Stores the players selected Pokemon
        public Pokemon PlayerPokemon { get; set; } = new Pokemon();

        // Stores the randomly selected opponent
        public Pokemon OpponentPokemon { get; set; } = new Pokemon();

        // Stores each Pokemons current health
        public int PlayerHealth { get; set; }

        public int OpponentHealth { get; set; }

        // Calculates how much damage an attack causes
        public int CalculateDamage(Pokemon attackingPokemon)
        {
            // Uses the Pokemons attack power as the damage
            int damage = attackingPokemon.Attack;

            return damage;
        }

        // Will load both Pokemon when the battle page opens
        public void OnGet(int selectedPokemon)
        {
            // Stores the Pokemon that the player selected
            List<Pokemon> availablePokemon = new List<Pokemon>();

            // Finds the players Pokemon and the other available Pokemon
            foreach (var pokemon in PokemonData.PokemonList)
            {
                if (pokemon.PokemonID == selectedPokemon)
                {
                    PlayerPokemon = pokemon;
                }
                else
                {
                    availablePokemon.Add(pokemon);
                }
            }

            // This will randomly choose one of the remaining five Pokemon 
            //to set as the opponent Pokemon
            Random random = new Random();
            int randomIndex = random.Next(availablePokemon.Count);

            OpponentPokemon = availablePokemon[randomIndex];

            // Sets both Pokemons health to their maximum health
            PlayerHealth = PlayerPokemon.MaxHP;
            OpponentHealth = OpponentPokemon.MaxHP;

            // Saves both Pokemons IDs in Session
            HttpContext.Session.SetInt32("PlayerPokemonID", PlayerPokemon.PokemonID);
            HttpContext.Session.SetInt32("OpponentPokemonID", OpponentPokemon.PokemonID);

            // Saves both Pokemons starting health
            HttpContext.Session.SetInt32("PlayerHealth", PlayerHealth);
            HttpContext.Session.SetInt32("OpponentHealth", OpponentHealth);
        }
    }
}