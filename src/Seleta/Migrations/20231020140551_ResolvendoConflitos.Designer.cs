﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Seleta.Data;

#nullable disable

namespace Seleta.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231020140551_ResolvendoConflitos")]
    partial class ResolvendoConflitos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Seleta.Models.Estabelecimento", b =>
                {
                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioCPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Cnpj");

                    b.HasIndex("UsuarioCPF");

                    b.ToTable("Estabelecimentos");
                });

            modelBuilder.Entity("Seleta.Models.Usuario", b =>
                {
                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CPF");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Seleta.Models.Estabelecimento", b =>
                {
                    b.HasOne("Seleta.Models.Usuario", "Usuario")
                        .WithMany("Estabelecimentos")
                        .HasForeignKey("UsuarioCPF")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Seleta.Models.Usuario", b =>
                {
                    b.Navigation("Estabelecimentos");
                });
#pragma warning restore 612, 618
        }
    }
}