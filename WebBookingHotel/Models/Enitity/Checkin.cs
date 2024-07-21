namespace WebBookingHotel.Models.Enitity
{
    public class Checkin
    {
        public int Ma_Checkin { get; set; }
        public int Sogio { get; set; }

        public int Giatien { get; set; }

        public string Ghichu { get; set; }

        public string Ma_LoaiPhong { get; set; }

        public Loaiphong Loaiphong { get; set; }    

    }
}
