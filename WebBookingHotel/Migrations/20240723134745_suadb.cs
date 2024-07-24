using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBookingHotel.Migrations
{
    public partial class suadb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop old foreign key and index
            migrationBuilder.DropIndex(
                name: "IX_Tangkhachsan_KhachsanMa_Khachsan",
                table: "Tangkhachsan");

            migrationBuilder.DropForeignKey(
                name: "FK_Tangkhachsan_Khachsan_KhachsanMa_Khachsan",
                table: "Tangkhachsan");

            // Alter column to match the referenced column's type
            migrationBuilder.AlterColumn<string>(
                name: "Ma_Khachsan",
                table: "Tangkhachsan",
                type: "NVARCHAR(455)", 
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(MAX)");

 
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
