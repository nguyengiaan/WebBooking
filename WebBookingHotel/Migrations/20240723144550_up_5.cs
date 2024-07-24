using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBookingHotel.Migrations
{
    public partial class up_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
       

      

            migrationBuilder.AddForeignKey(
                name: "FK_Tangkhachsan_Khachsan_Ma_Tang",
                table: "Tangkhachsan",
                column: "Ma_Tang",
                principalTable: "Khachsan",
                principalColumn: "Ma_Khachsan",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tangkhachsan_Khachsan_Ma_Tang",
                table: "Tangkhachsan");

            migrationBuilder.AddColumn<string>(
                name: "KhachsanMa_Khachsan",
                table: "Tangkhachsan",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Tangkhachsan_KhachsanMa_Khachsan",
                table: "Tangkhachsan",
                column: "KhachsanMa_Khachsan");

            migrationBuilder.AddForeignKey(
                name: "FK_Tangkhachsan_Khachsan_KhachsanMa_Khachsan",
                table: "Tangkhachsan",
                column: "KhachsanMa_Khachsan",
                principalTable: "Khachsan",
                principalColumn: "Ma_Khachsan",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
