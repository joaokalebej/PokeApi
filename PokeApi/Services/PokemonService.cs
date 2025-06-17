using PokeApiNet;

namespace PokeApi.Services;

public class PokemonService
{
    static async Task Main()
    {
        PokeApiClient pokeClient = new PokeApiClient();

        // Buscar um Pokémon específico
        Pokemon pikachu = await pokeClient.GetResourceAsync<Pokemon>("pikachu");

        Console.WriteLine($"Nome: {pikachu.Name}");
        Console.WriteLine($"Altura: {pikachu.Height}");
        Console.WriteLine($"Peso: {pikachu.Weight}");
    }
}