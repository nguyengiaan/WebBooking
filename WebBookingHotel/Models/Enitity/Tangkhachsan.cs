namespace WebBookingHotel.Models.Enitity
{
    public class Tangkhachsan
    {
        public Tangkhachsan()
        {
            Phongs = new List<Phong>();
        }
        public string Ma_Tang { get; set; }
        public string Ten_Tang { get; set; }

        public int Sophong { get; set; }

        public string Ghichu { get; set; }

        public string Trangthai { get; set; }

        public string Ma_Khachsan { get; set; }

        public Khachsan Khachsan { get; set; }

        public List<Phong> Phongs { get; set; }

    }
}
