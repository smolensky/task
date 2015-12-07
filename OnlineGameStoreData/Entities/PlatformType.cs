using System.ComponentModel.DataAnnotations;

namespace OnlineGameStoreData.Entities
{
    public class PlatformType
    {
        [Key]
        public string Type { get; set; }
    }
}