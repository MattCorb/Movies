using Microsoft.EntityFrameworkCore.Migrations;

namespace DateME.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<byte>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Major = table.Column<string>(nullable: true),
                    Crepe = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.ApplicationId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "Age", "Crepe", "FirstName", "LastName", "Major", "PhoneNumber" },
                values: new object[] { 1, (byte)23, false, "Matt", "Corbett", "IS", "555-555" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "ApplicationId", "Age", "Crepe", "FirstName", "LastName", "Major", "PhoneNumber" },
                values: new object[] { 2, (byte)50, true, "Creed", "Bratton", "N/A", "0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
