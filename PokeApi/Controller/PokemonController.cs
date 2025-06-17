using Microsoft.AspNetCore.Mvc;
using PokeApiNet;

namespace PokeApi.Controller;

public class PokemonController : Microsoft.AspNetCore.Mvc.Controller
{
    public async Task<IActionResult> Index()
    {
        PokeApiClient pokeClient = new();
    
        Pokemon var = await pokeClient.GetResourceAsync<Pokemon>("ho-oh");
        
        return View();
    }
}