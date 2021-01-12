using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoList.DataAccess.Migrations
{
    public partial class Partnamefixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Part_Projects_ProjectId",
                table: "Part");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Part_PartId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Part",
                table: "Part");

            migrationBuilder.RenameTable(
                name: "Part",
                newName: "Parts");

            migrationBuilder.RenameIndex(
                name: "IX_Part_ProjectId",
                table: "Parts",
                newName: "IX_Parts_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parts",
                table: "Parts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_Projects_ProjectId",
                table: "Parts",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Parts_PartId",
                table: "Tasks",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_Projects_ProjectId",
                table: "Parts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Parts_PartId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parts",
                table: "Parts");

            migrationBuilder.RenameTable(
                name: "Parts",
                newName: "Part");

            migrationBuilder.RenameIndex(
                name: "IX_Parts_ProjectId",
                table: "Part",
                newName: "IX_Part_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Part",
                table: "Part",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Part_Projects_ProjectId",
                table: "Part",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Part_PartId",
                table: "Tasks",
                column: "PartId",
                principalTable: "Part",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
