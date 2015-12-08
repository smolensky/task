using OnlineGameStoreData.Entities;

namespace OnlineGameStoreData.EntityWriters
{
    interface ICommentEntityWriter
    {
        CommentEntity CreateComment(CommentEntity comment);
    }
}