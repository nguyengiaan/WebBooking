namespace WebBookingHotel.Models.Enitity
{
    public class Khachdangkydatphong
    {
        public int Ma_khachdangkydatphong { get; set; }
        public string Ten_khachdangkydatphong { get; set; }
        public string Diachi { get; set; }
        public string Ghichu { get; set; }

        public string CCCD { get; set; }

        public DateTime Ngaycap { get; set; }
        public DateTime Ngaysinh { get; set; }

        public string Email { get; set; }

        public string Sodienthoai { get; set; }
        public string Gioitinh { get; set; }
        public string Quoctich { get; set; }

        public string Ma_DangKyDatPhong { get; set; }
        public Dangkydatphong Dangkydatphong { get; set; }


    }
}
