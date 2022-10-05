using TrybeGames;

namespace System
{
    static class GetLastIdExtensions
    {
        public static int LastId(this List<Player> database)
        {
            return database.OrderBy(i => i.Id).Last().Id + 1;
        }
        public static int LastId(this List<GameStudio> database)
        {
            return database.OrderBy(i => i.Id).Last().Id + 1;
        }
        public static int LastId(this List<Game> database)
        {
            return database.OrderBy(i => i.Id).Last().Id + 1;
        }
    }
}
