namespace WebBookingHotel.Models.Enitity
{
    public class Loaiphong
    {
        public Loaiphong()
        {
            Phongs = new List<Phong>();
            Checkouts = new List<Checkout>();
            Checkins = new List<Checkin>();
        }
        public string Ma_LoaiPhong { get; set; }
        public string Ten_loaiphong { get; set; }
        public int Sogiuong { get; set; }

        public int Songuoi { get; set; }

        public int Giatheongay { get; set; }

        public int Giatheogio { get; set; }

        public int Giatheothang { get; set; }

        public string Ghichu { get; set; }


        public List<Phong> Phongs { get; set; }  

        public List<Checkout> Checkouts { get; set; }

        public List<Checkin>Checkins { get; set; }

        public List<Giatheogio> Giatheogios { get; set; }
    }
}
