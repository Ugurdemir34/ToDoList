using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.DataAccess.Migrations
{
    public partial class DatabaseUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PartId",
                table: "Tasks",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Part",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    ProjectId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Part_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_PartId",
                table: "Tasks",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_Part_ProjectId",
                table: "Part",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Part_PartId",
                table: "Tasks",
                column: "PartId",
                principalTable: "Part",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Part_PartId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "Part");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_PartId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "PartId",
                table: "Tasks");
        }
    }
}
