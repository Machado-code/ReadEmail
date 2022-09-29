using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELEmail.Migrations
{
    public partial class CMDEasyLeadsAlterNameTable_V1001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProvedorEmail",
                table: "ProvedorEmail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmailConsumidor",
                table: "EmailConsumidor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consumidor",
                table: "Consumidor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CapturaEmails",
                table: "CapturaEmails");

            migrationBuilder.RenameTable(
                name: "ProvedorEmail",
                newName: "cmdProvedorEmail");

            migrationBuilder.RenameTable(
                name: "EmailConsumidor",
                newName: "cmdEmailConsumidor");

            migrationBuilder.RenameTable(
                name: "Consumidor",
                newName: "cmdConsumidor");

            migrationBuilder.RenameTable(
                name: "CapturaEmails",
                newName: "cmdCapturaEmails");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "cmdProvedorEmail",
                newName: "Cliente");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "cmdProvedorEmail",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "cmdProvedorEmail",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "cmdEmailConsumidor",
                type: "varchar(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "Mensagem",
                table: "cmdEmailConsumidor",
                type: "varchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AlterColumn<string>(
                name: "Loja",
                table: "cmdEmailConsumidor",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Carro",
                table: "cmdEmailConsumidor",
                type: "varchar(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "Assunto",
                table: "cmdEmailConsumidor",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "cmdConsumidor",
                type: "varchar(15)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "cmdConsumidor",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "cmdConsumidor",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cmdProvedorEmail",
                table: "cmdProvedorEmail",
                column: "IdProvedor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cmdEmailConsumidor",
                table: "cmdEmailConsumidor",
                column: "IdEmail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cmdConsumidor",
                table: "cmdConsumidor",
                column: "IdConsumidor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cmdCapturaEmails",
                table: "cmdCapturaEmails",
                column: "IdCaptura");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_cmdProvedorEmail",
                table: "cmdProvedorEmail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cmdEmailConsumidor",
                table: "cmdEmailConsumidor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cmdConsumidor",
                table: "cmdConsumidor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cmdCapturaEmails",
                table: "cmdCapturaEmails");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "cmdProvedorEmail");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "cmdProvedorEmail");

            migrationBuilder.RenameTable(
                name: "cmdProvedorEmail",
                newName: "ProvedorEmail");

            migrationBuilder.RenameTable(
                name: "cmdEmailConsumidor",
                newName: "EmailConsumidor");

            migrationBuilder.RenameTable(
                name: "cmdConsumidor",
                newName: "Consumidor");

            migrationBuilder.RenameTable(
                name: "cmdCapturaEmails",
                newName: "CapturaEmails");

            migrationBuilder.RenameColumn(
                name: "Cliente",
                table: "ProvedorEmail",
                newName: "IdCliente");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "EmailConsumidor",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mensagem",
                table: "EmailConsumidor",
                type: "varchar(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Loja",
                table: "EmailConsumidor",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Carro",
                table: "EmailConsumidor",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Assunto",
                table: "EmailConsumidor",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Consumidor",
                type: "varchar(15)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Consumidor",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Consumidor",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProvedorEmail",
                table: "ProvedorEmail",
                column: "IdProvedor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmailConsumidor",
                table: "EmailConsumidor",
                column: "IdEmail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consumidor",
                table: "Consumidor",
                column: "IdConsumidor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CapturaEmails",
                table: "CapturaEmails",
                column: "IdCaptura");
        }
    }
}
