using aula12_ef_test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aula12_ef_test.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.Id);
                
         

            // Configurar outras propriedades, relacionamentos e restrições, se necessário
            // Exemplo:
            // builder.Property(a => a.Name).IsRequired().HasMaxLength(50);
            // builder.HasMany(a => a.Books).WithOne(b => b.Author).HasForeignKey(b => b.AuthorId);
        }
    }

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
                
          

            // Configurar outras propriedades, relacionamentos e restrições, se necessário
            // Exemplo:
            // builder.Property(u => u.Name).IsRequired().HasMaxLength(50);
            // builder.HasMany(u => u.Books).WithOne(b => b.User).HasForeignKey(b => b.UserId);
        }
    }
}
