using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcelImportApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Table1s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsInjured = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelationDOB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Index = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentTableName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentIndex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubUUID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubValidation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubTags = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table1s", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table1s");
        }
    }
}
