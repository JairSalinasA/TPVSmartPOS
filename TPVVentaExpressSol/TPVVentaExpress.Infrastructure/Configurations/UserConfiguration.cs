// TPVVentaExpress.Infrastructure/Configurations/UserConfiguration.cs
using System.Data.Entity.ModelConfiguration;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Infrastructure.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users"); 
            HasKey(u => u.UserId);

            Property(u => u.Username)
                .HasMaxLength(50)
                .IsRequired();

            Property(u => u.Password)
                .HasMaxLength(100)
                .IsRequired();

            Property(u => u.Role)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
