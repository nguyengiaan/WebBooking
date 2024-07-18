namespace WebBookingHotel.Models.Enitity
{
    public class BookingRoom
    {
        public string Id_bookingroom { get; set; }
        public string Id_room { get; set; }
        public string Id_user { get; set; }
        public string DateCheckIn { get; set; }
        public string DateCheckOut { get; set; }
        public string NumberPeople { get; set; }
        public string NumberRoom { get; set; }
        public string TotalPrice { get; set; }
        public string Status { get; set; }
    }
}
