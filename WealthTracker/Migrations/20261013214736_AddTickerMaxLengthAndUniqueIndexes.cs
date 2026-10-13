using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WealthTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddTickerMaxLengthAndUniqueIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ticker",
                table: "Assets",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Sector",
                table: "Assets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_UserId_AssetId",
                table: "Positions",
                columns: new[] { "UserId", "AssetId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Assets_Ticker",
                table: "Assets",
                column: "Ticker",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Positions_UserId_AssetId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Assets_Ticker",
                table: "Assets");

            migrationBuilder.AlterColumn<string>(
                name: "Ticker",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Sector",
                table: "Assets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
