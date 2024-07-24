namespace WebBookingHotel.Models.Enitity
{
    public class Khachsan
    {
        public Khachsan()
        {
            Tangkhachsans = new List<Tangkhachsan>();
        }
        public string Ma_Khachsan { get; set; }
        public string Ten_Khachsan { get; set; }
        public int Soluongtang { get; set; }
        public int Soluongphong { get; set; }
        public string Diachi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Ghichu { get; set; }
        public DateTime ngaytao { get; set; }
        public string Id { get; set; }
        public ApplicationUser user { get; set; }
        public List<Tangkhachsan> Tangkhachsans { get; set; }


    }
}
