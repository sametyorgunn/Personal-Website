using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SametYorgun.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string BlogAdi { get; set; }
        public string BlogIcerik { get; set; }
        public string BlogTarihi { get; set; }
        public string BlogResimYol { get; set; }
        [NotMapped]
        public IFormFile BlogResim { get; set; }
        public bool Status { get; set; }

    }
}
