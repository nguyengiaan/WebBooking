using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBookingHotel.Migrations
{
    public partial class up_8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tangkhachsan_Khachsan_Ma_Tang",
                table: "Tangkhachsan");

            migrationBuilder.AlterColumn<string>(
                name: "Ma_Khachsan",
                table: "Tangkhachsan",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Tangkhachsan_Ma_Khachsan",
                table: "Tangkhachsan",
                column: "Ma_Khachsan");

            migrationBuilder.AddForeignKey(
                name: "FK_Tangkhachsan_Khachsan_Ma_Khachsan",
                table: "Tangkhachsan",
                column: "Ma_Khachsan",
                principalTable: "Khachsan",
                principalColumn: "Ma_Khachsan",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tangkhachsan_Khachsan_Ma_Khachsan",
                table: "Tangkhachsan");

            migrationBuilder.DropIndex(
                name: "IX_Tangkhachsan_Ma_Khachsan",
                table: "Tangkhachsan");

            migrationBuilder.AlterColumn<string>(
                name: "Ma_Khachsan",
                table: "Tangkhachsan",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Tangkhachsan_Khachsan_Ma_Tang",
                table: "Tangkhachsan",
                column: "Ma_Tang",
                principalTable: "Khachsan",
                principalColumn: "Ma_Khachsan",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
