using Microsoft.EntityFrameworkCore.Migrations;

namespace AzureDatabse.Migrations
{
    public partial class AzureDatabseModelsMovieContextInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Discription", "Duration", "Name" },
                values: new object[] { 1, " Action", 120.3f, "x-men" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
