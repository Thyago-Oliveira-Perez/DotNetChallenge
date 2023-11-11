using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PicPayApiChallenge.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transactions_clients_ClientId",
                table: "transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_transactions_shopkeepers_ShopkeeperId",
                table: "transactions");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "shopkeepers");

            migrationBuilder.RenameColumn(
                name: "ShopkeeperId",
                table: "transactions",
                newName: "TradesmanId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "transactions",
                newName: "CommonUserId");

            migrationBuilder.RenameIndex(
                name: "IX_transactions_ShopkeeperId",
                table: "transactions",
                newName: "IX_transactions_TradesmanId");

            migrationBuilder.RenameIndex(
                name: "IX_transactions_ClientId",
                table: "transactions",
                newName: "IX_transactions_CommonUserId");

            migrationBuilder.CreateTable(
                name: "commonUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commonUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tradesman",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(19)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tradesman", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "TradesmanId",
                table: "transactions",
                newName: "ShopkeeperId");

            migrationBuilder.RenameColumn(
                name: "CommonUserId",
                table: "transactions",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_transactions_TradesmanId",
                table: "transactions",
                newName: "IX_transactions_ShopkeeperId");

            migrationBuilder.RenameIndex(
                name: "IX_transactions_CommonUserId",
                table: "transactions",
                newName: "IX_transactions_ClientId");

            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "shopkeepers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", nullable: false),
                    ShopId = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shopkeepers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clients_CPF",
                table: "clients",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_clients_Email",
                table: "clients",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_shopkeepers_CPF",
                table: "shopkeepers",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_shopkeepers_Email",
                table: "shopkeepers",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_clients_ClientId",
                table: "transactions",
                column: "ClientId",
                principalTable: "clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_shopkeepers_ShopkeeperId",
                table: "transactions",
                column: "ShopkeeperId",
                principalTable: "shopkeepers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
