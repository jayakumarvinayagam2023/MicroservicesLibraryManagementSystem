using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthorService.Migrations
{
    /// <inheritdoc />
    public partial class mg_dec_1_0_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthodId",
                table: "Authors",
                newName: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Authors",
                newName: "AuthodId");
        }
    }
}
