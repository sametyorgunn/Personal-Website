using System.ComponentModel.DataAnnotations;

namespace SametYorgun.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string isim { get; set; }
        public string Mail { get; set; }
        public string Mesaj { get; set; }
    }
}
