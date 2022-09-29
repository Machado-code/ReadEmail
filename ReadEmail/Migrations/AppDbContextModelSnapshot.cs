﻿// <auto-generated />
using System;
using ELEmail.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ELEmail.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ELEmail.Models.CapturaEmails", b =>
                {
                    b.Property<int>("IdCaptura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("IdCaptura"));

                    b.Property<DateTime>("DataCaptura")
                        .HasColumnType("timestamp");

                    b.Property<DateTime>("DataEmailRebido")
                        .HasColumnType("timestamp");

                    b.Property<TimeOnly>("HoraCaptura")
                        .HasColumnType("time");

                    b.Property<TimeOnly>("HoraEmailRebido")
                        .HasColumnType("time");

                    b.Property<int>("IdConsumidor")
                        .HasColumnType("int");

                    b.Property<int>("IdProvedor")
                        .HasColumnType("int");

                    b.Property<bool>("IsFeriado")
                        .HasColumnType("bool");

                    b.Property<bool>("IsForaRotina")
                        .HasColumnType("bool");

                    b.HasKey("IdCaptura");

                    b.ToTable("cmd_captura_emails");
                });

            modelBuilder.Entity("ELEmail.Models.Consumidor", b =>
                {
                    b.Property<int>("IdConsumidor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("IdConsumidor"));

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdEmail")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(15)");

                    b.HasKey("IdConsumidor");

                    b.ToTable("cmd_consumidor");
                });

            modelBuilder.Entity("ELEmail.Models.EmailConsumidor", b =>
                {
                    b.Property<int>("IdEmail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("IdEmail"));

                    b.Property<string>("Assunto")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Carro")
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp");

                    b.Property<string>("Loja")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Mensagem")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Modelo")
                        .HasColumnType("varchar(30)");

                    b.HasKey("IdEmail");

                    b.ToTable("cmd_email_consumidor");
                });

            modelBuilder.Entity("ELEmail.Models.ProvedorEmail", b =>
                {
                    b.Property<int>("IdProvedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("IdProvedor"));

                    b.Property<string>("Cliente")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int>("Porta")
                        .HasColumnType("int");

                    b.Property<string>("Provedor")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Senha")
                        .HasColumnType("text");

                    b.Property<bool>("Ssl")
                        .HasColumnType("boolean");

                    b.Property<bool>("Tsl")
                        .HasColumnType("boolean");

                    b.HasKey("IdProvedor");

                    b.ToTable("cmd_provedor_email");
                });
#pragma warning restore 612, 618
        }
    }
}
