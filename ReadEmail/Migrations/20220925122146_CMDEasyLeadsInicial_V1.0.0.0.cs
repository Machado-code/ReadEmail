using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ELEmail.Migrations
{
    public partial class CMDEasyLeadsInicial_V1000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CapturaEmails",
                columns: table => new
                {
                    IdCaptura = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    IdProvedor = table.Column<int>(type: "int", nullable: false),
                    IdConsumidor = table.Column<int>(type: "int", nullable: false),
                    DataCaptura = table.Column<DateTime>(type: "timestamp", nullable: false),
                    HoraCaptura = table.Column<TimeOnly>(type: "time", nullable: false),
                    DataEmailRebido = table.Column<DateTime>(type: "timestamp", nullable: false),
                    HoraEmailRebido = table.Column<TimeOnly>(type: "time", nullable: false),
                    IsFeriado = table.Column<bool>(type: "bool", nullable: false),
                    IsForaRotina = table.Column<bool>(type: "bool", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapturaEmails", x => x.IdCaptura);
                });

            migrationBuilder.CreateTable(
                name: "Consumidor",
                columns: table => new
                {
                    IdConsumidor = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    IdEmail = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(15)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumidor", x => x.IdConsumidor);
                });

            migrationBuilder.CreateTable(
                name: "EmailConsumidor",
                columns: table => new
                {
                    IdEmail = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Data = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Assunto = table.Column<string>(type: "varchar(100)", nullable: false),
                    Mensagem = table.Column<string>(type: "varchar(200)", nullable: false),
                    Loja = table.Column<string>(type: "varchar(50)", nullable: false),
                    Carro = table.Column<string>(type: "varchar(30)", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailConsumidor", x => x.IdEmail);
                });

            migrationBuilder.CreateTable(
                name: "ProvedorEmail",
                columns: table => new
                {
                    IdProvedor = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    IdCliente = table.Column<string>(type: "varchar(10)", nullable: false),
                    Provedor = table.Column<string>(type: "varchar(30)", nullable: false),
                    Ssl = table.Column<bool>(type: "boolean", nullable: false),
                    Tsl = table.Column<bool>(type: "boolean", nullable: false),
                    Porta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvedorEmail", x => x.IdProvedor);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CapturaEmails");

            migrationBuilder.DropTable(
                name: "Consumidor");

            migrationBuilder.DropTable(
                name: "EmailConsumidor");

            migrationBuilder.DropTable(
                name: "ProvedorEmail");
        }
    }
}
