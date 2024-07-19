using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebBookingHotel.Models.Enitity;

namespace WebBookingHotel.Data
{
    public class MyDbcontext : IdentityDbContext<ApplicationUser>
    {
      

        public MyDbcontext(DbContextOptions<MyDbcontext> options) : base(options)
        {

        }
    }
}
