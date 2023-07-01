using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace connect_to_database.Migrations
{
    /// <inheritdoc />
    public partial class studentcategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoryes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movie_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category = table.Column<int>(type: "int", nullable: false),
                    collection = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    clas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "categoryes",
                columns: new[] { "id", "category", "collection", "movie_Name" },
                values: new object[] { 1, 5, 50, "Hary Potter" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "age", "clas", "name" },
                values: new object[] { 1, 20, "Vi", "Sudipta" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categoryes");

            migrationBuilder.DropTable(
                name: "students");
        }
    }
}