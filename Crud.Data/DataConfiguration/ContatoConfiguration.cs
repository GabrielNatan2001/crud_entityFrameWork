using Crud_Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crud.Data.DataConfiguration
{
    public class ContatoConfiguration : IEntityTypeConfiguration<EntidadeContato>
    {
        public void Configure(EntityTypeBuilder<EntidadeContato> builder)
        {
            builder.ToTable("Contato");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            //builder.HasOne(x=> x.Pessoa).WithMany(x=> x.Contatos).HasForeignKey(x => x.IdPessoa);

            builder.Property(x => x.Telefone)
                .IsRequired()
                .HasColumnType("varchar(10)");
        }
    }
}
