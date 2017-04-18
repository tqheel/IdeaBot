using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdeaBot.Migrations
{
    public partial class DropBatchCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumIdeasInBatch",
                table: "IdeaBatches");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumIdeasInBatch",
                table: "IdeaBatches",
                nullable: false,
                defaultValue: 0);
        }
    }
}
