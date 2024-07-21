namespace WebBookingHotel.Models.Enitity
{
    public class Dangkydatphong
    {

        public Dangkydatphong()
        {
            Chitietdichvu = new List<Chitietdichvu>();
            Khachdangkydatphongs = new List<Khachdangkydatphong>();
        }
        public string Ma_DangKyDatPhong { get; set; }
      
        public DateTime Ngayvao { get; set; }

        public DateTime Ngayra { get; set; }
        public string Phanloai { get; set; }

        public int  Tratruoc { get; set; }

        public int Giamtru { get; set; }
        public string Soxe { get; set; }

        public string Ghisodo { get; set; }

        public string Ghichu { get; set; }

        public string Trangthai { get; set; }
        public string Ma_Phong { get; set; }

        public Phong Phong { get; set; }

        public Dichvu Dichvu { get; set; }

        public List<Chitietdichvu> Chitietdichvu { get; set; }

        public List<Khachdangkydatphong> Khachdangkydatphongs { get; set; }

        
    }
}
