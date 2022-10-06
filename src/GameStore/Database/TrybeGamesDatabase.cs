using System.Collections.Generic;
using System.Numerics;

namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new();

    public List<GameStudio> GameStudios = new();

    public List<Player> Players = new();

    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        List<Game> games = Games.Where(gs => gs.DeveloperStudio == gameStudio.Id).ToList();
        return games;
    }

    public List<Game> GetGamesPlayedBy(Player player)
    {
        List<Game> players = Games.Where(g => g.Players.Select(p => p).Contains(player.Id)).ToList();

        return players;
        
    }

    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        List<Game> games = Games.Where(g => playerEntry.GamesOwned.Contains(g.Id)).ToList();

        return games;
    }
}
