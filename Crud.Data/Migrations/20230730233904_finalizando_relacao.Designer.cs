﻿// <auto-generated />
using System;
using Crud.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Crud.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230730233904_finalizando_relacao")]
    partial class finalizandorelacao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Crud_Domain.Entity.EntidadeContato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DDD")
                        .HasColumnType("int");

                    b.Property<int>("DDI")
                        .HasColumnType("int");

                    b.Property<int>("EntidadePessoaId")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("EntidadePessoaId");

                    b.ToTable("Contato", (string)null);
                });

            modelBuilder.Entity("Crud_Domain.Entity.EntidadePessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Pessoa", (string)null);
                });

            modelBuilder.Entity("Crud_Domain.Entity.EntidadeContato", b =>
                {
                    b.HasOne("Crud_Domain.Entity.EntidadePessoa", null)
                        .WithMany("Contatos")
                        .HasForeignKey("EntidadePessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Crud_Domain.Entity.EntidadePessoa", b =>
                {
                    b.Navigation("Contatos");
                });
#pragma warning restore 612, 618
        }
    }
}
