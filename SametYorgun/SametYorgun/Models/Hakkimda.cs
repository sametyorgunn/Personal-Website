using System.ComponentModel.DataAnnotations;

namespace SametYorgun.Models
{
    public class Hakkimda
    {
        [Key]
        public int Id { get; set; }
        public string HakkimdaIcerik { get; set; }
    }
}
