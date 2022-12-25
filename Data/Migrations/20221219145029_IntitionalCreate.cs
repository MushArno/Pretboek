using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pretboek.Data.Migrations
{
    public partial class IntitionalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    post_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    post_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    post_img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    post_author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    post_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    post_likes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.post_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");
        }
    }
}
