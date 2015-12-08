using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.EntityWriters
{
    public interface ICommentEntityWriter
    {
        CommentEntity CreateComment(CommentEntity comment);
    }
}