using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineGameStoreData.Entities
{
    public class PlatformTypeEntity
    {
        [Key]
        public string Type { get; set; }

        public ICollection<GameEntity> Games { get; set; }
    }
}