using Microsoft.EntityFrameworkCore.Migrations;

namespace SharedRoleplay.Migrations
{
    public partial class AddScenesController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scene",
                columns: table => new
                {
                    StoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scene", x => x.StoryID);
                    table.ForeignKey(
                        name: "FK_Scene_Story_StoryID",
                        column: x => x.StoryID,
                        principalTable: "Story",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scene");
        }
    }
}
