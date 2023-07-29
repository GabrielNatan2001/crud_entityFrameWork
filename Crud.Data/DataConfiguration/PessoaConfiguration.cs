using Crud_Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crud.Data.DataConfiguration
{
    public class PessoaConfiguration : IEntityTypeConfiguration<EntidadePessoa>
    {
        public void Configure(EntityTypeBuilder<EntidadePessoa> builder)
        {
            builder.ToTable("Pessoa");
                
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(x => x.SobreNome)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(x => x.DtNascimento)
                .IsRequired();
        }
    }
}
