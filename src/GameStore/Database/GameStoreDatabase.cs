using System.Collections.Generic;
using System.Numerics;

namespace GameStore;

public class GameStoreDatabase
{
    public List<Game> Games = new();

    public List<GameStudio> GameStudios = new();

    public List<Player> Players = new();

    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        // implementar
        List<Game> games = Games.Where(gs => gs.DeveloperStudio == gameStudio.Id).ToList();
        return games;
    }

    public List<Game> GetGamesPlayedBy(Player player)
    {
        // Implementar
        List<Game> players = Games.Where(g => g.Players.Select(p => p).Contains(player.Id)).ToList();

        return players;
        
    }

    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        // Implementar
        List<Game> games = Games.Where(g => playerEntry.GamesOwned.Contains(g.Id)).ToList();

        return games;
    }
}
