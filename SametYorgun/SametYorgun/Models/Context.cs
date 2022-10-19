using Microsoft.EntityFrameworkCore;

namespace SametYorgun.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SAMET;Initial Catalog=sametyorgun;Integrated Security=True;Pooling=False");
        }

        public DbSet<Blog> blogs { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Hakkimda>hakkimdas { get; set; }
        public DbSet<KisiselBilgi>kisiselBilgis { get; set; }
        public DbSet<Projeler> projelers { get; set; }
        public DbSet<giris>girises { get; set; }
    }
}
