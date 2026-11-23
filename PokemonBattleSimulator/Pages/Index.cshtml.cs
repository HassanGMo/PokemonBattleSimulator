using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PokemonBattleSimulator.Models;
using System.Collections.Generic;

namespace PokemonBattleSimulator.Pages
{
    public class IndexModel : PageModel
    {
        // Stores the list of all six Pokemon
        public List<Pokemon> PokemonList { get; set; } = new List<Pokemon>();

        // Stores the Pokemon selected by the player
        public Pokemon SelectedPokemon { get; set; } = new Pokemon();

        // When page is open this will loads the Pokemon list
        public void OnGet()
        {
            PokemonList = PokemonData.PokemonList;
        }

        // Receives the Pokémon selected by the player
        public IActionResult OnPost(string selectedPokemon)
        {
            // Gets the ID of the selected Pokémon
            int selectedID = int.Parse(selectedPokemon);

            // Sends the selected Pokémon ID to the battle page
            return RedirectToPage("/Battle", new { selectedPokemon = selectedID });
        }
    }
}