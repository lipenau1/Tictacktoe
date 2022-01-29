using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestArquive.Data.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.Property(p => p.Id).HasColumnType("CHAR(36)").IsRequired();
            builder.Property(p => p.NameUser).HasColumnType("VARCHAR(40)").IsRequired();
            builder.Property(p => p.SubName).HasColumnType("VARCHAR(40)").IsRequired();
            builder.Property(p => p.Email).HasColumnType("VARCHAR(40)").IsRequired();
            builder.Property(p => p.Phone).HasColumnType("VARCHAR(40)").IsRequired();
            builder.Property(p => p.Date).HasColumnType("VARCHAR(40)").IsRequired();
            builder.Property(p => p.Password).HasColumnType("VARCHAR(40)").IsRequired();
        }
    }
}
