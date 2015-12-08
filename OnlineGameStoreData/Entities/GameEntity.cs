using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineGameStoreData.Entities
{
    public class GameEntity
    {
        [Key]
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<CommentEntity> Comments { get; set; }
        public ICollection<GenreEntity> Genres { get; set; }
        public ICollection<PlatformTypeEntity> PlatformTypes { get; set; }
    }
}
