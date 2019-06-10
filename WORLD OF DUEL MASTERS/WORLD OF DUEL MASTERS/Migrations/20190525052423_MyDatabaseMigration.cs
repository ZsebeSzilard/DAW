using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WORLD_OF_DUEL_MASTERS.Migrations
{
    public partial class MyDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountID = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountID);
                });

            migrationBuilder.CreateTable(
                name: "DMCards",
                columns: table => new
                {
                    CardID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Set = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Civilization = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Rarity = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Cost = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Flavor = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Illustrator = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Race = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Power = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Races0 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Races1 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Civilizations0 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Civilizations1 = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMCards", x => x.CardID);
                });

            migrationBuilder.CreateTable(
                name: "Deck",
                columns: table => new
                {
                    DeckID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AccountID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deck", x => x.DeckID);
                    table.ForeignKey(
                        name: "FK_Deck_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    CardID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Set = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Civilization = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Rarity = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Cost = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Flavor = table.Column<string>(type: "nvarchar(400)", nullable: true),
                    Illustrator = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Race = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Power = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Races0 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Races1 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Civilizations0 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Civilizations1 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    DeckID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.CardID);
                    table.ForeignKey(
                        name: "FK_Card_Deck_DeckID",
                        column: x => x.DeckID,
                        principalTable: "Deck",
                        principalColumn: "DeckID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Card_DeckID",
                table: "Card",
                column: "DeckID");

            migrationBuilder.CreateIndex(
                name: "IX_Deck_AccountID",
                table: "Deck",
                column: "AccountID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "DMCards");

            migrationBuilder.DropTable(
                name: "Deck");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
