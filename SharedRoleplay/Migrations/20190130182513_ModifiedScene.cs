using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SharedRoleplay.Migrations
{
    public partial class ModifiedScene : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scene_Story_StoryID",
                table: "Scene");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Scene",
                table: "Scene");

            migrationBuilder.AlterColumn<int>(
                name: "StoryID",
                table: "Scene",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Scene",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Scene",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Setting",
                table: "Scene",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Scene",
                table: "Scene",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Scene_StoryID",
                table: "Scene",
                column: "StoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Scene_Story_StoryID",
                table: "Scene",
                column: "StoryID",
                principalTable: "Story",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Scene_Story_StoryID",
                table: "Scene");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Scene",
                table: "Scene");

            migrationBuilder.DropIndex(
                name: "IX_Scene_StoryID",
                table: "Scene");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Scene");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Scene");

            migrationBuilder.DropColumn(
                name: "Setting",
                table: "Scene");

            migrationBuilder.AlterColumn<int>(
                name: "StoryID",
                table: "Scene",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Scene",
                table: "Scene",
                column: "StoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Scene_Story_StoryID",
                table: "Scene",
                column: "StoryID",
                principalTable: "Story",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
