using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELEmail.Migrations
{
    public partial class CMDEasyLeadsAlterNameTable_V1002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameTable(
                name: "cmdProvedorEmail",
                newName: "cmd_provedor_email");

            migrationBuilder.RenameTable(
                name: "cmdEmailConsumidor",
                newName: "cmd_email_consumidor");

            migrationBuilder.RenameTable(
                name: "cmdConsumidor",
                newName: "cmd_consumidor");

            migrationBuilder.RenameTable(
                name: "cmdCapturaEmails",
                newName: "cmd_captura_emails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cmd_provedor_email",
                table: "cmd_provedor_email",
                column: "IdProvedor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cmd_email_consumidor",
                table: "cmd_email_consumidor",
                column: "IdEmail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cmd_consumidor",
                table: "cmd_consumidor",
                column: "IdConsumidor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cmd_captura_emails",
                table: "cmd_captura_emails",
                column: "IdCaptura");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_cmd_provedor_email",
                table: "cmd_provedor_email");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cmd_email_consumidor",
                table: "cmd_email_consumidor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cmd_consumidor",
                table: "cmd_consumidor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cmd_captura_emails",
                table: "cmd_captura_emails");

            migrationBuilder.RenameTable(
                name: "cmd_provedor_email",
                newName: "cmdProvedorEmail");

            migrationBuilder.RenameTable(
                name: "cmd_email_consumidor",
                newName: "cmdEmailConsumidor");

            migrationBuilder.RenameTable(
                name: "cmd_consumidor",
                newName: "cmdConsumidor");

            migrationBuilder.RenameTable(
                name: "cmd_captura_emails",
                newName: "cmdCapturaEmails");

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
    }
}
