﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SafeWeb.Data.Data;

namespace SafeWeb.Data.Migrations
{
    [DbContext(typeof(SafeWebContext))]
    [Migration("20190403001742_atualizacao_02")]
    partial class atualizacao_02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SafeWeb_Domain.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("SafeWeb_Domain.Entities.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj")
                        .HasColumnName("cnpj")
                        .HasMaxLength(21);

                    b.Property<string>("Cpf")
                        .HasColumnName("cpf")
                        .HasMaxLength(15);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasMaxLength(80);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasMaxLength(80);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnName("telefone")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("SafeWeb_Domain.Entities.HistoricoProposta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("descricao")
                        .HasMaxLength(255);

                    b.Property<int>("IdProposta");

                    b.Property<int>("IdUsuario")
                        .HasColumnName("id_proposta");

                    b.Property<DateTime>("data");

                    b.HasKey("Id");

                    b.HasIndex("IdProposta");

                    b.HasIndex("IdUsuario");

                    b.ToTable("HistoricoProposta");
                });

            modelBuilder.Entity("SafeWeb_Domain.Entities.Proposta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AprovadaAnalistaCompras")
                        .HasColumnName("aprovada_analista_compras");

                    b.Property<bool>("AprovadaAnalistaFinanceiro")
                        .HasColumnName("aprovada_analista_financeiro");

                    b.Property<bool>("AprovadaDiretorFinanceiro")
                        .HasColumnName("aprovada_diretor_financeiro");

                    b.Property<string>("CaminhoArquivo")
                        .HasColumnName("caminho_arquivo");

                    b.Property<DateTime>("Data")
                        .HasColumnName("data");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("descricao");

                    b.Property<int>("IdCategoria")
                        .HasColumnName("id_categoria");

                    b.Property<int>("IdFornecedor")
                        .HasColumnName("id_fornecedor");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasMaxLength(100);

                    b.Property<decimal>("Valor")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("IdFornecedor");

                    b.ToTable("Proposta");
                });

            modelBuilder.Entity("SafeWeb_Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnName("cpf")
                        .HasMaxLength(15);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnName("login")
                        .HasMaxLength(20);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasMaxLength(80);

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .HasColumnName("perfil")
                        .HasMaxLength(20);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnName("senha")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("Login")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("SafeWeb_Domain.Entities.HistoricoProposta", b =>
                {
                    b.HasOne("SafeWeb_Domain.Entities.Proposta", "proposta")
                        .WithMany()
                        .HasForeignKey("IdProposta")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SafeWeb_Domain.Entities.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SafeWeb_Domain.Entities.Proposta", b =>
                {
                    b.HasOne("SafeWeb_Domain.Entities.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SafeWeb_Domain.Entities.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("IdFornecedor")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
