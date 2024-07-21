using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBookingHotel.Migrations
{
    public partial class up_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khachsan",
                columns: table => new
                {
                    Ma_Khachsan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten_Khachsan = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Soluongtang = table.Column<int>(type: "int", nullable: false),
                    Soluongphong = table.Column<int>(type: "int", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngaytao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachsan", x => x.Ma_Khachsan);
                    table.ForeignKey(
                        name: "FK_Khachsan_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Loaidichvu",
                columns: table => new
                {
                    Ma_LoaiDichVu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten_LoaiDichVu = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loaidichvu", x => x.Ma_LoaiDichVu);
                });

            migrationBuilder.CreateTable(
                name: "Loaiphong",
                columns: table => new
                {
                    Ma_LoaiPhong = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten_loaiphong = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Sogiuong = table.Column<int>(type: "int", nullable: false),
                    Songuoi = table.Column<int>(type: "int", nullable: false),
                    Giatheongay = table.Column<int>(type: "int", nullable: false),
                    Giatheogio = table.Column<int>(type: "int", nullable: false),
                    Giatheothang = table.Column<int>(type: "int", nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loaiphong", x => x.Ma_LoaiPhong);
                });

            migrationBuilder.CreateTable(
                name: "Tangkhachsan",
                columns: table => new
                {
                    Ma_Tang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten_Tang = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Sophong = table.Column<int>(type: "int", nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ma_Khachsan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhachsanMa_Khachsan = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tangkhachsan", x => x.Ma_Tang);
                    table.ForeignKey(
                        name: "FK_Tangkhachsan_Khachsan_KhachsanMa_Khachsan",
                        column: x => x.KhachsanMa_Khachsan,
                        principalTable: "Khachsan",
                        principalColumn: "Ma_Khachsan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dichvu",
                columns: table => new
                {
                    Ma_DichVu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten_DichVu = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Gia = table.Column<int>(type: "int", nullable: false),
                    NhaSX = table.Column<int>(type: "int", maxLength: 2147483647, nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ma_LoaiDichVu = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dichvu", x => x.Ma_DichVu);
                    table.ForeignKey(
                        name: "FK_Dichvu_Loaidichvu_Ma_LoaiDichVu",
                        column: x => x.Ma_LoaiDichVu,
                        principalTable: "Loaidichvu",
                        principalColumn: "Ma_LoaiDichVu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checkin",
                columns: table => new
                {
                    Ma_Checkin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sogio = table.Column<int>(type: "int", nullable: false),
                    Giatien = table.Column<int>(type: "int", nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ma_LoaiPhong = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkin", x => x.Ma_Checkin);
                    table.ForeignKey(
                        name: "FK_Checkin_Loaiphong_Ma_LoaiPhong",
                        column: x => x.Ma_LoaiPhong,
                        principalTable: "Loaiphong",
                        principalColumn: "Ma_LoaiPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checkout",
                columns: table => new
                {
                    Ma_Checkout = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sogio = table.Column<int>(type: "int", nullable: false),
                    Giatien = table.Column<int>(type: "int", nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ma_LoaiPhong = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkout", x => x.Ma_Checkout);
                    table.ForeignKey(
                        name: "FK_Checkout_Loaiphong_Ma_LoaiPhong",
                        column: x => x.Ma_LoaiPhong,
                        principalTable: "Loaiphong",
                        principalColumn: "Ma_LoaiPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Giatheogio",
                columns: table => new
                {
                    Ma_GiaTheoGio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sogio = table.Column<int>(type: "int", nullable: false),
                    Giatien = table.Column<int>(type: "int", nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ma_LoaiPhong = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giatheogio", x => x.Ma_GiaTheoGio);
                    table.ForeignKey(
                        name: "FK_Giatheogio_Loaiphong_Ma_LoaiPhong",
                        column: x => x.Ma_LoaiPhong,
                        principalTable: "Loaiphong",
                        principalColumn: "Ma_LoaiPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phong",
                columns: table => new
                {
                    Ma_Phong = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten_Phong = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ma_Tang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ma_LoaiPhong = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phong", x => x.Ma_Phong);
                    table.ForeignKey(
                        name: "FK_Phong_Loaiphong_Ma_LoaiPhong",
                        column: x => x.Ma_LoaiPhong,
                        principalTable: "Loaiphong",
                        principalColumn: "Ma_LoaiPhong",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phong_Tangkhachsan_Ma_Tang",
                        column: x => x.Ma_Tang,
                        principalTable: "Tangkhachsan",
                        principalColumn: "Ma_Tang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dangkydatphong",
                columns: table => new
                {
                    Ma_DangKyDatPhong = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ngayvao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ngayra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phanloai = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Tratruoc = table.Column<int>(type: "int", nullable: false),
                    Giamtru = table.Column<int>(type: "int", nullable: false),
                    Soxe = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ghisodo = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ma_Phong = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DichvuMa_DichVu = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dangkydatphong", x => x.Ma_DangKyDatPhong);
                    table.ForeignKey(
                        name: "FK_Dangkydatphong_Dichvu_DichvuMa_DichVu",
                        column: x => x.DichvuMa_DichVu,
                        principalTable: "Dichvu",
                        principalColumn: "Ma_DichVu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dangkydatphong_Phong_Ma_Phong",
                        column: x => x.Ma_Phong,
                        principalTable: "Phong",
                        principalColumn: "Ma_Phong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chitietdichvu",
                columns: table => new
                {
                    Ma_ChitietDV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ma_DangKyDatPhong = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ma_DichVu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitietdichvu", x => x.Ma_ChitietDV);
                    table.ForeignKey(
                        name: "FK_Chitietdichvu_Dangkydatphong_Ma_DangKyDatPhong",
                        column: x => x.Ma_DangKyDatPhong,
                        principalTable: "Dangkydatphong",
                        principalColumn: "Ma_DangKyDatPhong",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Chitietdichvu_Dichvu_Ma_DichVu",
                        column: x => x.Ma_DichVu,
                        principalTable: "Dichvu",
                        principalColumn: "Ma_DichVu",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Khachdangkydatphong",
                columns: table => new
                {
                    Ma_khachdangkydatphong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten_khachdangkydatphong = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ngaycap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ngaysinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Sodienthoai = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Gioitinh = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Quoctich = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Ma_DangKyDatPhong = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachdangkydatphong", x => x.Ma_khachdangkydatphong);
                    table.ForeignKey(
                        name: "FK_Khachdangkydatphong_Dangkydatphong_Ma_DangKyDatPhong",
                        column: x => x.Ma_DangKyDatPhong,
                        principalTable: "Dangkydatphong",
                        principalColumn: "Ma_DangKyDatPhong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Checkin_Ma_LoaiPhong",
                table: "Checkin",
                column: "Ma_LoaiPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_Ma_LoaiPhong",
                table: "Checkout",
                column: "Ma_LoaiPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietdichvu_Ma_DangKyDatPhong",
                table: "Chitietdichvu",
                column: "Ma_DangKyDatPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietdichvu_Ma_DichVu",
                table: "Chitietdichvu",
                column: "Ma_DichVu");

            migrationBuilder.CreateIndex(
                name: "IX_Dangkydatphong_DichvuMa_DichVu",
                table: "Dangkydatphong",
                column: "DichvuMa_DichVu");

            migrationBuilder.CreateIndex(
                name: "IX_Dangkydatphong_Ma_Phong",
                table: "Dangkydatphong",
                column: "Ma_Phong");

            migrationBuilder.CreateIndex(
                name: "IX_Dichvu_Ma_LoaiDichVu",
                table: "Dichvu",
                column: "Ma_LoaiDichVu");

            migrationBuilder.CreateIndex(
                name: "IX_Giatheogio_Ma_LoaiPhong",
                table: "Giatheogio",
                column: "Ma_LoaiPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Khachdangkydatphong_Ma_DangKyDatPhong",
                table: "Khachdangkydatphong",
                column: "Ma_DangKyDatPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Khachsan_Id",
                table: "Khachsan",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_Ma_LoaiPhong",
                table: "Phong",
                column: "Ma_LoaiPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_Ma_Tang",
                table: "Phong",
                column: "Ma_Tang");

            migrationBuilder.CreateIndex(
                name: "IX_Tangkhachsan_KhachsanMa_Khachsan",
                table: "Tangkhachsan",
                column: "KhachsanMa_Khachsan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkin");

            migrationBuilder.DropTable(
                name: "Checkout");

            migrationBuilder.DropTable(
                name: "Chitietdichvu");

            migrationBuilder.DropTable(
                name: "Giatheogio");

            migrationBuilder.DropTable(
                name: "Khachdangkydatphong");

            migrationBuilder.DropTable(
                name: "Dangkydatphong");

            migrationBuilder.DropTable(
                name: "Dichvu");

            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "Loaidichvu");

            migrationBuilder.DropTable(
                name: "Loaiphong");

            migrationBuilder.DropTable(
                name: "Tangkhachsan");

            migrationBuilder.DropTable(
                name: "Khachsan");
        }
    }
}
