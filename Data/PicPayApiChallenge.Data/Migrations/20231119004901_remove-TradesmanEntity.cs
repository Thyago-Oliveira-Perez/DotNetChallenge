using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PicPayApiChallenge.Data.Migrations
{
    /// <inheritdoc />
    public partial class removeTradesmanEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transactions_commonUsers_CommonUserId",
                table: "transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_transactions_tradesman_TradesmanId",
                table: "transactions");

            migrationBuilder.DropTable(
                name: "commonUsers");

            migrationBuilder.DropTable(
                name: "tradesman");

            migrationBuilder.DropIndex(
                name: "IX_transactions_CommonUserId",
                table: "transactions");

            migrationBuilder.DropIndex(
                name: "IX_transactions_TradesmanId",
                table: "transactions");

            migrationBuilder.RenameColumn(
                name: "TradesmanId",
                table: "transactions",
                newName: "PayerId");

            migrationBuilder.RenameColumn(
                name: "CommonUserId",
                table: "transactions",
                newName: "PayeeId");

            migrationBuilder.AddColumn<Guid>(
                name: "UserEntityId",
                table: "transactions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Type = table.Column<string>(type: "varchar(10)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(18)", nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", nullable: false),
                    Balance = table.Column<decimal>(type: "money", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "date", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_transactions_UserEntityId",
                table: "transactions",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_users_CNPJ",
                table: "users",
                column: "CNPJ",
                unique: true,
                filter: "[CNPJ] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_users_CPF",
                table: "users",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_Email",
                table: "users",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_users_UserEntityId",
                table: "transactions",
                column: "UserEntityId",
                principalTable: "users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transactions_users_UserEntityId",
                table: "transactions");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropIndex(
                name: "IX_transactions_UserEntityId",
                table: "transactions");

            migrationBuilder.DropColumn(
                name: "UserEntityId",
                table: "transactions");

            migrationBuilder.RenameColumn(
                name: "PayerId",
                table: "transactions",
                newName: "TradesmanId");

            migrationBuilder.RenameColumn(
                name: "PayeeId",
                table: "transactions",
                newName: "CommonUserId");

            migrationBuilder.CreateTable(
                name: "commonUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Balance = table.Column<decimal>(type: "money", nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "date", nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commonUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tradesman",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Balance = table.Column<decimal>(type: "money", nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(18)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "date", nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tradesman", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_transactions_CommonUserId",
                table: "transactions",
                column: "CommonUserId");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_TradesmanId",
                table: "transactions",
                column: "TradesmanId");

            migrationBuilder.CreateIndex(
                name: "IX_commonUsers_CPF",
                table: "commonUsers",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_commonUsers_Email",
                table: "commonUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tradesman_CNPJ",
                table: "tradesman",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tradesman_CPF",
                table: "tradesman",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tradesman_Email",
                table: "tradesman",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_commonUsers_CommonUserId",
                table: "transactions",
                column: "CommonUserId",
                principalTable: "commonUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_tradesman_TradesmanId",
                table: "transactions",
                column: "TradesmanId",
                principalTable: "tradesman",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
