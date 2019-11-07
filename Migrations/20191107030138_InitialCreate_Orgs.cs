using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace verbose_disco.Migrations
{
    public partial class InitialCreate_Orgs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orgs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SourcedId = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    DateLastModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Identifier = table.Column<string>(nullable: true),
                    ParentSourcedId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orgs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orgs");
        }
    }
}
