using Crud_Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Data.DataConfiguration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<EntidadeUsuario>
    {
        public void Configure(EntityTypeBuilder<EntidadeUsuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Usuario)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Senha)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(x => x.Perfil)
                 .IsRequired()
                 .HasColumnType("varchar(100)");
        }
    }
}
