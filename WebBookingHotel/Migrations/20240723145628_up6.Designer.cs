﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebBookingHotel.Data;

#nullable disable

namespace WebBookingHotel.Migrations
{
    [DbContext(typeof(MyDbcontext))]
    [Migration("20240723145628_up6")]
    partial class up6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Checkin", b =>
                {
                    b.Property<int>("Ma_Checkin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ma_Checkin"), 1L, 1);

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Giatien")
                        .HasColumnType("int");

                    b.Property<string>("Ma_LoaiPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Sogio")
                        .HasColumnType("int");

                    b.HasKey("Ma_Checkin");

                    b.HasIndex("Ma_LoaiPhong");

                    b.ToTable("Checkin", (string)null);
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Checkout", b =>
                {
                    b.Property<int>("Ma_Checkout")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ma_Checkout"), 1L, 1);

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Giatien")
                        .HasColumnType("int");

                    b.Property<string>("Ma_LoaiPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Sogio")
                        .HasColumnType("int");

                    b.HasKey("Ma_Checkout");

                    b.HasIndex("Ma_LoaiPhong");

                    b.ToTable("Checkout", (string)null);
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Chitietdichvu", b =>
                {
                    b.Property<int>("Ma_ChitietDV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ma_ChitietDV"), 1L, 1);

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma_DangKyDatPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ma_DichVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Ma_ChitietDV");

                    b.HasIndex("Ma_DangKyDatPhong");

                    b.HasIndex("Ma_DichVu");

                    b.ToTable("Chitietdichvu", (string)null);
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Dangkydatphong", b =>
                {
                    b.Property<string>("Ma_DangKyDatPhong")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DichvuMa_DichVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ghisodo")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Giamtru")
                        .HasColumnType("int");

                    b.Property<string>("Ma_Phong")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Ngayra")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ngayvao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phanloai")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soxe")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trangthai")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tratruoc")
                        .HasColumnType("int");

                    b.HasKey("Ma_DangKyDatPhong");

                    b.HasIndex("DichvuMa_DichVu");

                    b.HasIndex("Ma_Phong");

                    b.ToTable("Dangkydatphong", (string)null);
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Dichvu", b =>
                {
                    b.Property<string>("Ma_DichVu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gia")
                        .HasColumnType("int");

                    b.Property<string>("Ma_LoaiDichVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("NhaSX")
                        .HasMaxLength(2147483647)
                        .HasColumnType("int");

                    b.Property<string>("Ten_DichVu")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ma_DichVu");

                    b.HasIndex("Ma_LoaiDichVu");

                    b.ToTable("Dichvu", (string)null);
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Giatheogio", b =>
                {
                    b.Property<int>("Ma_GiaTheoGio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ma_GiaTheoGio"), 1L, 1);

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Giatien")
                        .HasColumnType("int");

                    b.Property<string>("Ma_LoaiPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Sogio")
                        .HasColumnType("int");

                    b.HasKey("Ma_GiaTheoGio");

                    b.HasIndex("Ma_LoaiPhong");

                    b.ToTable("Giatheogio", (string)null);
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Khachdangkydatphong", b =>
                {
                    b.Property<int>("Ma_khachdangkydatphong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ma_khachdangkydatphong"), 1L, 1);

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diachi")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gioitinh")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma_DangKyDatPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Ngaycap")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ngaysinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Quoctich")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sodienthoai")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten_khachdangkydatphong")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ma_khachdangkydatphong");

                    b.HasIndex("Ma_DangKyDatPhong");

                    b.ToTable("Khachdangkydatphong", (string)null);
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Khachsan", b =>
                {
                    b.Property<string>("Ma_Khachsan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Diachi")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Soluongphong")
                        .HasColumnType("int");

                    b.Property<int>("Soluongtang")
                        .HasColumnType("int");

                    b.Property<string>("Ten_Khachsan")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngaytao")
                        .HasColumnType("datetime2");

                    b.HasKey("Ma_Khachsan");

                    b.HasIndex("Id");

                    b.ToTable("Khachsan", (string)null);
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Loaidichvu", b =>
                {
                    b.Property<string>("Ma_LoaiDichVu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten_LoaiDichVu")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ma_LoaiDichVu");

                    b.ToTable("Loaidichvu", (string)null);
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Loaiphong", b =>
                {
                    b.Property<string>("Ma_LoaiPhong")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Giatheogio")
                        .HasColumnType("int");

                    b.Property<int>("Giatheongay")
                        .HasColumnType("int");

                    b.Property<int>("Giatheothang")
                        .HasColumnType("int");

                    b.Property<int>("Sogiuong")
                        .HasColumnType("int");

                    b.Property<int>("Songuoi")
                        .HasColumnType("int");

                    b.Property<string>("Ten_loaiphong")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ma_LoaiPhong");

                    b.ToTable("Loaiphong", (string)null);
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Phong", b =>
                {
                    b.Property<string>("Ma_Phong")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma_LoaiPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ma_Tang")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ten_Phong")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trangthai")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ma_Phong");

                    b.HasIndex("Ma_LoaiPhong");

                    b.HasIndex("Ma_Tang");

                    b.ToTable("Phong", (string)null);
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Tangkhachsan", b =>
                {
                    b.Property<string>("Ma_Tang")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma_Khachsan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sophong")
                        .HasColumnType("int");

                    b.Property<string>("Ten_Tang")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trangthai")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ma_Tang");

                    b.ToTable("Tangkhachsan", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebBookingHotel.Models.Enitity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebBookingHotel.Models.Enitity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebBookingHotel.Models.Enitity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebBookingHotel.Models.Enitity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Checkin", b =>
                {
                    b.HasOne("WebBookingHotel.Models.Enitity.Loaiphong", "Loaiphong")
                        .WithMany("Checkins")
                        .HasForeignKey("Ma_LoaiPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loaiphong");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Checkout", b =>
                {
                    b.HasOne("WebBookingHotel.Models.Enitity.Loaiphong", "Loaiphong")
                        .WithMany("Checkouts")
                        .HasForeignKey("Ma_LoaiPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loaiphong");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Chitietdichvu", b =>
                {
                    b.HasOne("WebBookingHotel.Models.Enitity.Dangkydatphong", "Dangkydatphong")
                        .WithMany("Chitietdichvu")
                        .HasForeignKey("Ma_DangKyDatPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebBookingHotel.Models.Enitity.Dichvu", "Dichvu")
                        .WithMany("Chitietdichvu")
                        .HasForeignKey("Ma_DichVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dangkydatphong");

                    b.Navigation("Dichvu");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Dangkydatphong", b =>
                {
                    b.HasOne("WebBookingHotel.Models.Enitity.Dichvu", "Dichvu")
                        .WithMany()
                        .HasForeignKey("DichvuMa_DichVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebBookingHotel.Models.Enitity.Phong", "Phong")
                        .WithMany("dangkydatphongs")
                        .HasForeignKey("Ma_Phong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dichvu");

                    b.Navigation("Phong");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Dichvu", b =>
                {
                    b.HasOne("WebBookingHotel.Models.Enitity.Loaidichvu", "Loaidichvu")
                        .WithMany("Dichvu")
                        .HasForeignKey("Ma_LoaiDichVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loaidichvu");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Giatheogio", b =>
                {
                    b.HasOne("WebBookingHotel.Models.Enitity.Loaiphong", "Loaiphong")
                        .WithMany("Giatheogios")
                        .HasForeignKey("Ma_LoaiPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loaiphong");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Khachdangkydatphong", b =>
                {
                    b.HasOne("WebBookingHotel.Models.Enitity.Dangkydatphong", "Dangkydatphong")
                        .WithMany("Khachdangkydatphongs")
                        .HasForeignKey("Ma_DangKyDatPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dangkydatphong");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Khachsan", b =>
                {
                    b.HasOne("WebBookingHotel.Models.Enitity.ApplicationUser", "user")
                        .WithMany("Khachsans")
                        .HasForeignKey("Id");

                    b.Navigation("user");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Phong", b =>
                {
                    b.HasOne("WebBookingHotel.Models.Enitity.Loaiphong", "loaiphong")
                        .WithMany("Phongs")
                        .HasForeignKey("Ma_LoaiPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebBookingHotel.Models.Enitity.Tangkhachsan", "tangkhachsan")
                        .WithMany("Phongs")
                        .HasForeignKey("Ma_Tang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("loaiphong");

                    b.Navigation("tangkhachsan");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Tangkhachsan", b =>
                {
                    b.HasOne("WebBookingHotel.Models.Enitity.Khachsan", "Khachsan")
                        .WithMany("Tangkhachsans")
                        .HasForeignKey("Ma_Tang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Khachsan");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.ApplicationUser", b =>
                {
                    b.Navigation("Khachsans");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Dangkydatphong", b =>
                {
                    b.Navigation("Chitietdichvu");

                    b.Navigation("Khachdangkydatphongs");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Dichvu", b =>
                {
                    b.Navigation("Chitietdichvu");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Khachsan", b =>
                {
                    b.Navigation("Tangkhachsans");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Loaidichvu", b =>
                {
                    b.Navigation("Dichvu");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Loaiphong", b =>
                {
                    b.Navigation("Checkins");

                    b.Navigation("Checkouts");

                    b.Navigation("Giatheogios");

                    b.Navigation("Phongs");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Phong", b =>
                {
                    b.Navigation("dangkydatphongs");
                });

            modelBuilder.Entity("WebBookingHotel.Models.Enitity.Tangkhachsan", b =>
                {
                    b.Navigation("Phongs");
                });
#pragma warning restore 612, 618
        }
    }
}
