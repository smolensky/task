using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.EntityWriters
{
    interface IGameEntityWriter
    {
        GameEntity CreateGame(GameEntity entity);
    }
}
