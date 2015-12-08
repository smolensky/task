using System.Linq;
using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.EntityReaders
{
    public interface ICommentEntityReader
    {
        IQueryable<CommentEntity> ReadAll(GameEntity gameEntity);
    }
}