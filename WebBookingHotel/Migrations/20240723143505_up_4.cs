using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBookingHotel.Migrations
{
    public partial class up_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                               name: "KhachsanMa_Khachsan",
                                              table: "Tangkhachsan");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
