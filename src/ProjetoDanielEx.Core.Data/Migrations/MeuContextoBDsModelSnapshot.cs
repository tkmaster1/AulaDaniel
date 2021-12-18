﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoDanielEx.Core.Data;

namespace ProjetoDanielEx.Core.Data.Migrations
{
    [DbContext(typeof(MeuContextoBDs))]
    partial class MeuContextoBDsModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoDanielEx.Core.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_alteracao");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_inclusao");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2")
                        .HasColumnName("dt_exclusao");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("documento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nome");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("status");

                    b.Property<string>("TipoPessoa")
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("tipo_pessoa");

                    b.HasKey("Codigo");

                    b.ToTable("cliente", "dbo");
                });

            modelBuilder.Entity("ProjetoDanielEx.Core.Domain.Entities.Endereco", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("CodigoCliente")
                        .HasColumnType("int")
                        .HasColumnName("idCliente");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Codigo");

                    b.HasIndex("CodigoCliente")
                        .IsUnique()
                        .HasFilter("[idCliente] IS NOT NULL");

                    b.ToTable("endereco");
                });

            modelBuilder.Entity("ProjetoDanielEx.Core.Domain.Entities.Endereco", b =>
                {
                    b.HasOne("ProjetoDanielEx.Core.Domain.Entities.Cliente", "Cliente")
                        .WithOne("Endereco")
                        .HasForeignKey("ProjetoDanielEx.Core.Domain.Entities.Endereco", "CodigoCliente");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ProjetoDanielEx.Core.Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}
