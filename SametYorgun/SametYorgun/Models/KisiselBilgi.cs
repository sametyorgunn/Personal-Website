using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SametYorgun.Models
{
    public class KisiselBilgi
    {
        [Key]
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Unvan { get; set; }
        public string Github { get; set; }
        public string Linkedin { get; set; }
        public string Instagram { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public string DogumTarihi { get; set; }
        public string? ProfilResimYol { get; set; }
        [NotMapped]
        public IFormFile ProfilResim { get; set; }
        public string? CvYol { get; set; }
        [NotMapped]
        public IFormFile Cv { get; set; }
    }
}
