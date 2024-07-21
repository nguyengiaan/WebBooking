namespace WebBookingHotel.Models.Enitity
{
    public class Chitietdichvu
    {
        public int Ma_ChitietDV { get; set; }

        public string Ma_DangKyDatPhong { get; set; }

        public string Ma_DichVu { get; set; }

        public string Ghichu { get; set; }

        public Dangkydatphong Dangkydatphong { get; set; }
        public Dichvu Dichvu { get; set; }

    }
}
