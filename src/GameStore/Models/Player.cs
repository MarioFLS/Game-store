namespace GameStore;

public class Player
{
    public int Id;

    public string Name = "";

    public List<int> FavoriteGameStudios = new();

    public List<int> GamesOwned = new();

    public void AddGameStudioToFavorites(GameStudio gameStudioToAdd)
    {
        FavoriteGameStudios.Add(gameStudioToAdd.Id);
    }

    public void BuyGame(Game gameToBuy)
    {
        GamesOwned.Add(gameToBuy.Id);
    }
}
