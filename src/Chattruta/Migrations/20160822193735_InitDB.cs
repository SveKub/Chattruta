using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Chattruta.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chattmeddelande",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(nullable: false),
                    Meddelande = table.Column<string>(maxLength: 240, nullable: true),
                    Namn = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chattmeddelande", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chattmeddelande");
        }
    }
}
