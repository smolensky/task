using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.EntityWriters
{
     public interface IGameEntityWriter
    {
        GameEntity CreateGame(GameEntity entity);
    }
}
