using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdeaBot.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdeaBatches",
                columns: table => new
                {
                    IdeaBatchId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdeaBatchTime = table.Column<long>(nullable: false),
                    IdeaText = table.Column<string>(nullable: true),
                    IdeaTime = table.Column<long>(nullable: false),
                    NumIdeasInBatch = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdeaBatches", x => x.IdeaBatchId);
                });

            migrationBuilder.CreateTable(
                name: "Ideas",
                columns: table => new
                {
                    IdeaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdeaBatchId = table.Column<int>(nullable: false),
                    IdeaText = table.Column<string>(nullable: true),
                    IdeaTime = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ideas", x => x.IdeaId);
                    table.ForeignKey(
                        name: "FK_Ideas_IdeaBatches_IdeaBatchId",
                        column: x => x.IdeaBatchId,
                        principalTable: "IdeaBatches",
                        principalColumn: "IdeaBatchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ideas_IdeaBatchId",
                table: "Ideas",
                column: "IdeaBatchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ideas");

            migrationBuilder.DropTable(
                name: "IdeaBatches");
        }
    }
}
