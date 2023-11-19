﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Seleta.Data;

#nullable disable

namespace Seleta.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Seleta.Models.ListaDeCompras", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Email");

                    b.ToTable("ListaDeCompras");
                });

            modelBuilder.Entity("Seleta.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CnpjEstabelecimento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Imagem")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Preco")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadePeso")
                        .HasColumnType("int");

                    b.Property<int>("Restricoes")
                        .HasColumnType("int");

                    b.Property<string>("TipoImagem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CnpjEstabelecimento");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Seleta.Models.ProdutosListaDeCompras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ListaDeComprasEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ListaDeComprasEmail");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ProdutosListaDeCompras");
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

            modelBuilder.Entity("Seleta.Models.Produto", b =>
                {
                    b.HasOne("Seleta.Models.Estabelecimento", "Estabelecimento")
                        .WithMany()
<<<<<<< HEAD
                        .HasForeignKey("CnpjEstabelecimento");
=======
                        .HasForeignKey("CnpjEstabelecimento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
>>>>>>> main

                    b.Navigation("Estabelecimento");
                });

<<<<<<< HEAD
=======
            modelBuilder.Entity("Seleta.Models.ProdutosListaDeCompras", b =>
                {
                    b.HasOne("Seleta.Models.ListaDeCompras", "ListaDeCompras")
                        .WithMany("Produtos")
                        .HasForeignKey("ListaDeComprasEmail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Seleta.Models.Produto", "Produto")
                        .WithMany("ListasDeCompras")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ListaDeCompras");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Seleta.Models.ListaDeCompras", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Seleta.Models.Produto", b =>
                {
                    b.Navigation("ListasDeCompras");
                });

>>>>>>> main
            modelBuilder.Entity("Seleta.Models.Usuario", b =>
                {
                    b.Navigation("Estabelecimentos");
                });
#pragma warning restore 612, 618
        }
    }
}
