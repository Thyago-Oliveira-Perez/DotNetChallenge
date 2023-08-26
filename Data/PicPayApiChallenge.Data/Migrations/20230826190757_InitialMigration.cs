using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PicPayApiChallenge.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
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
                    table.PrimaryKey("PK_clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "shopkeepers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ShopId = table.Column<Guid>(type: "uuid", nullable: false),
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
                    table.PrimaryKey("PK_shopkeepers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ShopkeeperId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transactions_clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transactions_shopkeepers_ShopkeeperId",
                        column: x => x.ShopkeeperId,
                        principalTable: "shopkeepers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_transactions_ClientId",
                table: "transactions",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_ShopkeeperId",
                table: "transactions",
                column: "ShopkeeperId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transactions");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "shopkeepers");
        }
    }
}
