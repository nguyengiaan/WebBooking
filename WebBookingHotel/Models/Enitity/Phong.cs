namespace WebBookingHotel.Models.Enitity
{
    public class Phong
    {
        public Phong()
        {
            dangkydatphongs = new List<Dangkydatphong>();
        }
        public string Ma_Phong { get; set; }
        public string Ten_Phong { get; set; }
        public string Trangthai { get; set; }
        public string Ghichu { get; set; }
        public string Ma_Tang { get; set; }
        public  string Ma_LoaiPhong { get; set; }

        public Tangkhachsan tangkhachsan { get; set; }

        public Loaiphong loaiphong { get; set; }

        public List<Dangkydatphong> dangkydatphongs { get; set; }

    }
}
