using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebBookingHotel.Models.Enitity;

namespace WebBookingHotel.Data
{
    public class MyDbcontext : IdentityDbContext<ApplicationUser>
    {
        public MyDbcontext(DbContextOptions<MyDbcontext> options) : base(options) { }
        #region Db
        public DbSet<ApplicationUser> Nguoidung { get; set; }
        public DbSet<Checkin> Checkin { get; set; }
        public DbSet<Checkout> Checkout { get; set; }
        public DbSet<Dangkydatphong> Dangkydatphong { get; set; }
        public DbSet<Dichvu> Dichvu { get; set; }
        public DbSet<Giatheogio> Giatheogio { get; set; }
        public DbSet<Khachdangkydatphong> Khachdangkydatphong { get; set; }
        public DbSet<Khachsan> Khachsan { get; set; }
        public DbSet<Loaidichvu> loaidichvu { get; set; }
        public DbSet<Loaiphong> Loaiphong { get; set; }
        public DbSet<Phong> Phong { get; set; }
        public DbSet<Tangkhachsan> Tangkhachsan { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //table khachsan
            modelBuilder.Entity<Khachsan>().ToTable("Khachsan").HasKey(e => e.Ma_Khachsan);
            modelBuilder.Entity<Khachsan>().Property(e => e.Ten_Khachsan).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Khachsan>().Property(e => e.Soluongtang);
            modelBuilder.Entity<Khachsan>().Property(e => e.Soluongphong);
            modelBuilder.Entity<Khachsan>().Property(e => e.Diachi).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Khachsan>().Property(e => e.SDT).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Khachsan>().Property(e => e.Email).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Khachsan>().Property(e => e.Website).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Khachsan>().Property(e => e.ngaytao);
            modelBuilder.Entity<Khachsan>().HasOne(e=>e.user).WithMany(e =>e.Khachsans ).HasForeignKey(e => e.Id);
            //table TangKhachsan
            modelBuilder.Entity<Tangkhachsan>().ToTable("Tangkhachsan").HasKey(e => e.Ma_Tang);
            modelBuilder.Entity<Tangkhachsan>().Property(e => e.Ten_Tang).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Tangkhachsan>().Property(e => e.Sophong);
            modelBuilder.Entity<Tangkhachsan>().Property(e => e.Ghichu).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Tangkhachsan>().Property(e => e.Trangthai).HasMaxLength(int.MaxValue);
         
            //table phong
            modelBuilder.Entity<Phong>().ToTable("Phong").HasKey(e => e.Ma_Phong);
            modelBuilder.Entity<Phong>().Property(e => e.Ten_Phong).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Phong>().Property(e => e.Trangthai).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Phong>().Property(e => e.Ghichu).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Phong>().HasOne(e => e.tangkhachsan).WithMany(e => e.Phongs).HasForeignKey(x => x.Ma_Tang);
            modelBuilder.Entity<Phong>().HasOne(e => e.loaiphong).WithMany(e => e.Phongs).HasForeignKey(x => x.Ma_LoaiPhong);

            //table Loaiphong
            modelBuilder.Entity<Loaiphong>().ToTable("Loaiphong").HasKey(e => e.Ma_LoaiPhong);
            modelBuilder.Entity<Loaiphong>().Property(e => e.Ten_loaiphong).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Loaiphong>().Property(e => e.Sogiuong);
            modelBuilder.Entity<Loaiphong>().Property(e => e.Songuoi);
            modelBuilder.Entity<Loaiphong>().Property(e => e.Giatheongay);
            modelBuilder.Entity<Loaiphong>().Property(e => e.Giatheogio);
            modelBuilder.Entity<Loaiphong>().Property(e => e.Giatheothang);
            modelBuilder.Entity<Loaiphong>().Property(e => e.Ghichu).HasMaxLength(int.MaxValue);
            //table Checkout
            modelBuilder.Entity<Checkout>().ToTable("Checkout").HasKey(e => e.Ma_Checkout);
            modelBuilder.Entity<Checkout>().Property(e => e.Ma_Checkout).ValueGeneratedOnAdd();
            modelBuilder.Entity<Checkout>().Property(e => e.Sogio);
            modelBuilder.Entity<Checkout>().Property(e => e.Giatien);
            modelBuilder.Entity<Checkout>().Property(e => e.Ghichu).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Checkout>().HasOne(e => e.Loaiphong).WithMany(e => e.Checkouts).HasForeignKey(x => x.Ma_LoaiPhong);
            //table Checkin
            modelBuilder.Entity<Checkin>().ToTable("Checkin").HasKey(e => e.Ma_Checkin);
            modelBuilder.Entity<Checkin>().Property(e => e.Ma_Checkin).ValueGeneratedOnAdd();
            modelBuilder.Entity<Checkin>().Property(e => e.Sogio);
            modelBuilder.Entity<Checkin>().Property(e => e.Giatien);
            modelBuilder.Entity<Checkin>().Property(e => e.Ghichu).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Checkin>().HasOne(e => e.Loaiphong).WithMany(e => e.Checkins).HasForeignKey(x => x.Ma_LoaiPhong);
            //table Giabantheogio
            modelBuilder.Entity<Giatheogio>().ToTable("Giatheogio").HasKey(e => e.Ma_GiaTheoGio);
            modelBuilder.Entity<Giatheogio>().Property(e => e.Sogio);
            modelBuilder.Entity<Giatheogio>().Property(e => e.Giatien);
            modelBuilder.Entity<Giatheogio>().Property(e => e.Ghichu).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Giatheogio>().HasOne(e => e.Loaiphong).WithMany(e => e.Giatheogios).HasForeignKey(x => x.Ma_LoaiPhong);
            //table Chitietdichvu
            modelBuilder.Entity<Chitietdichvu>().ToTable("Chitietdichvu").HasKey(e => e.Ma_ChitietDV);
            modelBuilder.Entity<Chitietdichvu>().Property(e => e.Ma_ChitietDV).ValueGeneratedOnAdd();
            modelBuilder.Entity<Chitietdichvu>().Property(e => e.Ghichu).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Chitietdichvu>().HasOne(e => e.Dangkydatphong).WithMany(e => e.Chitietdichvu).HasForeignKey(x => x.Ma_DangKyDatPhong);
            modelBuilder.Entity<Chitietdichvu>().HasOne(e => e.Dichvu).WithMany(e => e.Chitietdichvu).HasForeignKey(x => x.Ma_DichVu);
            //table Dangkydatphong
            modelBuilder.Entity<Khachdangkydatphong>().ToTable("Khachdangkydatphong").HasKey(e => e.Ma_khachdangkydatphong);
            modelBuilder.Entity<Khachdangkydatphong>().Property(e => e.Ma_khachdangkydatphong).ValueGeneratedOnAdd();
            modelBuilder.Entity<Khachdangkydatphong>().Property(e => e.Ten_khachdangkydatphong).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Khachdangkydatphong>().Property(e => e.Diachi).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Khachdangkydatphong>().Property(e => e.Ghichu).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Khachdangkydatphong>().Property(e => e.CCCD).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Khachdangkydatphong>().Property(e => e.Ngaycap);
            modelBuilder.Entity<Khachdangkydatphong>().Property(e => e.Ngaysinh);
            modelBuilder.Entity<Khachdangkydatphong>().Property(e => e.Email).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Khachdangkydatphong>().Property(e => e.Sodienthoai).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Khachdangkydatphong>().Property(e => e.Gioitinh).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Khachdangkydatphong>().Property(e => e.Quoctich).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Khachdangkydatphong>().HasOne(e => e.Dangkydatphong).WithMany(e => e.Khachdangkydatphongs).HasForeignKey(x => x.Ma_DangKyDatPhong);
            //table Dangkydatphong
            modelBuilder.Entity<Dangkydatphong>().ToTable("Dangkydatphong").HasKey(e => e.Ma_DangKyDatPhong);
            modelBuilder.Entity<Dangkydatphong>().Property(e => e.Ma_DangKyDatPhong);
            modelBuilder.Entity<Dangkydatphong>().Property(e => e.Ngayvao);
            modelBuilder.Entity<Dangkydatphong>().Property(e => e.Ngayra);
            modelBuilder.Entity<Dangkydatphong>().Property(e => e.Phanloai).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Dangkydatphong>().Property(e => e.Tratruoc);
            modelBuilder.Entity<Dangkydatphong>().Property(e => e.Giamtru);
            modelBuilder.Entity<Dangkydatphong>().Property(e => e.Soxe).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Dangkydatphong>().Property(e => e.Ghisodo).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Dangkydatphong>().Property(e => e.Ghichu).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Dangkydatphong>().Property(e => e.Trangthai).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Dangkydatphong>().HasOne(e => e.Phong).WithMany(e => e.dangkydatphongs).HasForeignKey(x => x.Ma_Phong);
            //table Loaidichvu
            modelBuilder.Entity<Loaidichvu>().ToTable("Loaidichvu").HasKey(e => e.Ma_LoaiDichVu);
            modelBuilder.Entity<Loaidichvu>().Property(e => e.Ten_LoaiDichVu).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Loaidichvu>().Property(e => e.Ghichu).HasMaxLength(int.MaxValue);
            //table Dichvu
            modelBuilder.Entity<Dichvu>().ToTable("Dichvu").HasKey(e => e.Ma_DichVu);
            modelBuilder.Entity<Dichvu>().Property(e => e.Ten_DichVu).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Dichvu>().Property(e => e.Gia);
            modelBuilder.Entity<Dichvu>().Property(e => e.NhaSX).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Dichvu>().Property(e => e.Ghichu).HasMaxLength(int.MaxValue);
            modelBuilder.Entity<Dichvu>().HasOne(e => e.Loaidichvu).WithMany(e => e.Dichvu).HasForeignKey(x => x.Ma_LoaiDichVu);





        }

    }
}
