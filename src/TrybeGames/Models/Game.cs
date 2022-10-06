namespace TrybeGames;

public enum GameType
{
    Action = 1,
    Adventure,
    Puzzle,
    Strategy,
    Simulation,
    Sports,
    Other
};

public class Game
{
    public int Id;

    public string Name = "";

    public DateTime ReleaseDate;

    public GameType GameType;

    public int DeveloperStudio;

    public List<int> Players = new();


    public void AddPlayer(Player playerToAdd)
    {
        Players.Add(playerToAdd.Id);
    }

    public void RemovePlayer(Player playerToRemove)
    {
        Players.Remove(playerToRemove.Id);
    }

    public override string ToString()
    {
        return $"Id: {Id}, Game: {Name}, Data: {ReleaseDate}, type: {GameType}, Studio: {DeveloperStudio}";
    }
}
