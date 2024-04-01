using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IdentityProject.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3396a6b0-7c4b-4a63-8652-5f0ce2bf3f9b", null, "admin", "admin" },
                    { "7c169ead-4d94-4038-bef7-8d32ea510e13", null, "seller", "seller" },
                    { "db053962-f7bd-46de-aeca-0954d32cd02a", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3396a6b0-7c4b-4a63-8652-5f0ce2bf3f9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c169ead-4d94-4038-bef7-8d32ea510e13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db053962-f7bd-46de-aeca-0954d32cd02a");
        }
    }
}
