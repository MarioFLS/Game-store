using TrybeGames;

namespace System
{
    static class GetLastIdExtensions
    {
        public static int LastId(this List<Player> database)
        {
            return database.Last().Id;
        }
        public static int LastId(this List<GameStudio> database)
        {
            return database.Last().Id;
        }
        public static int LastId(this List<Game> database)
        {
            return database.Last().Id;
        }
    }
}
