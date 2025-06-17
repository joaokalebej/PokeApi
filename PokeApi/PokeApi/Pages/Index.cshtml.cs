using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeApi.Services;
using PokeApiNet;

namespace PokeApi.Pages;

public class IndexModel : PageModel
{
    private readonly PokeApiService _pokeApiService;
    public Pokemon PokemonInfo { get; set; }
    
    public IndexModel(PokeApiService pokeApiService)
    {
        _pokeApiService = pokeApiService;
    }

    public async Task OnGetAsync(string pokemonName)
    {
        PokemonInfo = await _pokeApiService.GetPokemonAsync(pokemonName);
    }
    
}