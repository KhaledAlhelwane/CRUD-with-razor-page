using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalProfit.Migrations
{
    /// <inheritdoc />
    public partial class newcolum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "User");
        }
    }
}
