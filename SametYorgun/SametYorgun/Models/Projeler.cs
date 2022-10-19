using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SametYorgun.Models
{
    public class Projeler
    {
        [Key]
        public int Id { get; set; }
        public string ProjeAdi { get; set; }
        public string ProjeIcerik { get; set; }
        public string ProjeResimYol { get; set; }
        [NotMapped]
        public IFormFile ProjeResim { get; set; }
        public bool Status { get; set; }
    }
}
