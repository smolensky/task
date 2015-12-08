using System.Linq;
using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.EntityReaders
{
    public class GameEntityReader : IGameEntityReader
    {
        private readonly DatabaseContext _databaseContext;

        public GameEntityReader(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }


        public IQueryable<GameEntity> ReadAll()
        {
            var result = _databaseContext.Games;
            return result;
        }

        public GameEntity ReadByKey(string key)
        {
            var result = _databaseContext.Games.FirstOrDefault(x => x.Key == key);
            return result;
        }

        public IQueryable<GameEntity> ReadByGenre(GenreEntity genre)
        {
            var result = _databaseContext.Games.Where(x => x.Genres.Contains(genre));
            return result;
        }

        public IQueryable<GameEntity> ReadByPlatformType(PlatformTypeEntity platformType)
        {
            var result = _databaseContext.Games.Where(x => x.PlatformTypes.Contains(platformType));
            return result;
        }
    }
}