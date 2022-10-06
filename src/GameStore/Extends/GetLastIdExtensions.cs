using System.Linq;
using GameStore;

namespace System
{
    static class GetLastIdExtensions
    {
        public static int LastId(this List<Player> database)
        {
            return database.Select(d => d.Id).DefaultIfEmpty(0).OrderBy(i => i).Last() + 1;
        }
        public static int LastId(this List<GameStudio> database)
        {
            return database.Select(d => d.Id).DefaultIfEmpty(0).OrderBy(i => i).Last() + 1;

        }
        public static int LastId(this List<Game> database)
        {
            return database.Select(d => d.Id).DefaultIfEmpty(0).OrderBy(i => i).Last() + 1;
        }
    }
}
