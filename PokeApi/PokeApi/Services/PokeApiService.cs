using Newtonsoft.Json;
using PokeApiNet;

namespace PokeApi.Services;

public class PokeApiService
{
    private readonly HttpClient _httpClient;

    public PokeApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<Pokemon> GetPokemonAsync(string name)
    {
        var response = await _httpClient.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{name}");
        return JsonConvert.DeserializeObject<Pokemon>(response);
    }
}