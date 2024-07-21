namespace WebBookingHotel.Models.Enitity
{
    public class Dichvu
    {
        public string Ma_DichVu { get; set; }
        public string Ten_DichVu { get; set; }
        public int Gia { get; set; }
        public int NhaSX { get; set; }
        public string Ghichu { get; set; }
        public string Ma_LoaiDichVu { get; set; }

        public List<Chitietdichvu> Chitietdichvu { get; set; }

        public Loaidichvu Loaidichvu { get; set; }

    }
}
