using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalProfit.Migrations
{
    /// <inheritdoc />
    public partial class khaled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonthlyPyment = table.Column<double>(type: "float", nullable: false),
                    Allamount = table.Column<double>(type: "float", nullable: false),
                    RemainingQuantity = table.Column<double>(type: "float", nullable: false),
                    PrecentageProfit = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
