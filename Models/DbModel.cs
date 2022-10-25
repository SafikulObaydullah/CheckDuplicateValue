using Microsoft.EntityFrameworkCore;

namespace CheckDuplicateValue.Models
{
   public class DbModel : DbContext
   {
      public DbModel(DbContextOptions options):base(options)
      {

      }
      public DbSet<Product> Products { get; set; } 
   }
}
