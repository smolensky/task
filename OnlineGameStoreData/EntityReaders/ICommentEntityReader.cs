using System.Linq;
using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.EntityReaders
{
    interface ICommentEntityReader
    {
        IQueryable<CommentEntity> ReadAll(GameEntity gameEntity);
    }
}