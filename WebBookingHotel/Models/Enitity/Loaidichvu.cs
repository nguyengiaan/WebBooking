namespace WebBookingHotel.Models.Enitity
{
    public class Loaidichvu
    {
        public Loaidichvu()
        {
            Dichvu = new List<Dichvu>();
        }
        public string Ma_LoaiDichVu { get; set; }
        public string Ten_LoaiDichVu { get; set; }
        public string Ghichu { get; set; }

        public List<Dichvu> Dichvu { get; set; }
    }
}
