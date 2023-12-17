using Microsoft.EntityFrameworkCore.Migrations;

namespace Book_List.Migrations
{
    public partial class Q2Assignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "course_info",
                columns: table => new
                {
                    course_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    lecturer_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_info", x => x.course_Id);
                });

            migrationBuilder.CreateTable(
                name: "student_info",
                columns: table => new
                {
                    student_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    course_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student_info", x => x.student_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "course_info");

            migrationBuilder.DropTable(
                name: "student_info");
        }
    }
}
