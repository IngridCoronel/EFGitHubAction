using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PrincipalEFCoreMVC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdFormSf = table.Column<int>(type: "integer", nullable: false),
                    IdSf = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DateReceivedProcesar = table.Column<DateTime>(type: "date", nullable: false),
                    DateSendProcesar = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    reasenRejection = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true),
                    sentSf = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Year = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Holidays",
                columns: new[] { "Id", "Date", "Year" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2024" },
                    { 2, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "2024" },
                    { 3, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2024" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "Holidays");
        }
    }
}
