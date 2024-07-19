using Microsoft.AspNetCore.Identity;

namespace WebBookingHotel.Models.Enitity
{
    public class ApplicationUser : IdentityUser
    {
        public string fullname { get; set; }

        public string address { get; set; } 

        public string Country { get; set; }
    }
}
