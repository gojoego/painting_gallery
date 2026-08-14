using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaintingGallery.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddArtworkConstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Artworks",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Artworks_Status_CreatedDate",
                table: "Artworks",
                columns: new[] { "Status", "CreatedDate" },
                descending: new[] { false, true });

            migrationBuilder.AddCheckConstraint(
                name: "CK_Artworks_Price_NonNegative",
                table: "Artworks",
                sql: "[Price] >= 0");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Artworks_Status",
                table: "Artworks",
                sql: "[Status] IN ('Draft', 'Published')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Artworks_Status_CreatedDate",
                table: "Artworks");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Artworks_Price_NonNegative",
                table: "Artworks");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Artworks_Status",
                table: "Artworks");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Artworks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
