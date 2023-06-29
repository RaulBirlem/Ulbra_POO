using aula12_ef_test.Data;
using aula12_ef_test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using aula12_ef_test.Data.Configurations;
namespace aula12_ef_test.Data
{
   public class DataContext : DbContext
    {
       public string DbPath { get; }

        public DataContext()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "aula.db");
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<User> User { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
       /*  public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.HasIndex(a => a.Id).IsUnique();
        } */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.ApplyConfiguration(new AuthorConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
   

        base.OnModelCreating(modelBuilder);
        }

    }
}