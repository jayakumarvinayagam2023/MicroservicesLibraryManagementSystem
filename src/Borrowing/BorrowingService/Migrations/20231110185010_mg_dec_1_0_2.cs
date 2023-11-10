using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BorrowingService.Migrations
{
    /// <inheritdoc />
    public partial class mg_dec_1_0_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "microservices");

            migrationBuilder.CreateTable(
                name: "Borrowings",
                schema: "microservices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BorrowingId = table.Column<Guid>(type: "uuid", nullable: false),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    BorrowingDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    ReturnDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    User = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowings", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Borrowings",
                schema: "microservices");
        }
    }
}
