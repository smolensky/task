using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineGameStoreData.Entities
{
    public class GameEntity
    {
        [Key]
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
