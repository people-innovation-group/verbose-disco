﻿using System;
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
                    sourcedId = table.Column<Guid>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    dateLastModified = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    identifier = table.Column<string>(nullable: true),
                    classification = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    boarding = table.Column<bool>(nullable: false),
                    parentSourcedId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orgs", x => x.sourcedId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orgs");
        }
    }
}
