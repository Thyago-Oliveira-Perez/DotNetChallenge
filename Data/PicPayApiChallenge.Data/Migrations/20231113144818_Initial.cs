using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PicPayApiChallenge.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "commonUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal", nullable: false)
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
                    CNPJ = table.Column<string>(type: "varchar(18)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(14)", nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tradesman", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    CommonUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    TradesmanId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transactions_commonUsers_CommonUserId",
                        column: x => x.CommonUserId,
                        principalTable: "commonUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transactions_tradesman_TradesmanId",
                        column: x => x.TradesmanId,
                        principalTable: "tradesman",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_transactions_CommonUserId",
                table: "transactions",
                column: "CommonUserId");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_TradesmanId",
                table: "transactions",
                column: "TradesmanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transactions");

            migrationBuilder.DropTable(
                name: "commonUsers");

            migrationBuilder.DropTable(
                name: "tradesman");
        }
    }
}
