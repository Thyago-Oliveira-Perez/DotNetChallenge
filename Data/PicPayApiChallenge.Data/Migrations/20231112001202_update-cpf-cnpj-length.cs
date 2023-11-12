using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PicPayApiChallenge.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatecpfcnpjlength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "tradesman",
                type: "varchar(14)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(11)");

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "tradesman",
                type: "varchar(18)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(19)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "commonUsers",
                type: "varchar(14)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(11)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "tradesman",
                type: "varchar(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(14)");

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "tradesman",
                type: "varchar(19)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(18)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "commonUsers",
                type: "varchar(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(14)");
        }
    }
}
