using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class UserPopulation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Users", new string[] { "Id", "Nombre", "Apellido", "Email", "Password" }, new object[] { 1, "Pablo", "Bianco", "pablo.m.bianco@hotmail.com", "Password123!" }, null);
            migrationBuilder.InsertData("Users", new string[] { "Id", "Nombre", "Apellido", "Email", "Password" }, new object[] { 2, "example1", "Random", "example1@hotmail.com", "Password123!" }, null);
            migrationBuilder.InsertData("Users", new string[] { "Id", "Nombre", "Apellido", "Email", "Password" }, new object[] { 3, "example2", "Random", "example2@hotmail.com", "Password123!" }, null);
            migrationBuilder.InsertData("Users", new string[] { "Id", "Nombre", "Apellido", "Email", "Password" }, new object[] { 4, "example3", "Random", "example3@hotmail.com", "Password123!" }, null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData("Users", "Id", new object[] { 1, 2, 3, 4 }, null);
        }
    }
}
