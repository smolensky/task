using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.EntityWriters
{
    public class GameEntityWriter : IGameEntityWriter
    {
        private readonly DatabaseContext _databaseContext;

        public GameEntityWriter(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public GameEntity CreateGame(GameEntity entity)
        {
            var result = _databaseContext.Games.Add(entity);
            _databaseContext.SaveChanges();
            return result;
        }
    }
}