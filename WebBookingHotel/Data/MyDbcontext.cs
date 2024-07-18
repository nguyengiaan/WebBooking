using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebBookingHotel.Models.Enitity;

namespace WebBookingHotel.Data
{
    public class MyDbcontext : IdentityDbContext<ApplicationUser>
    {
        #region db
        public DbSet<ApplicationUser> User { get; set; }
        public DbSet<BookingRoom> BookingRoom { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Convenient> Convenient { get; set; }
        public DbSet<Destination> Destination { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<ImageHotel> ImageHotel { get; set; }
        public DbSet<ImageNews> ImageNews { get; set; }
        public DbSet<ImageRoom> ImageRoom { get; set; }
        public DbSet<News> News { get; set; }   
        public DbSet<Payload> Payload { get; set; }
        public DbSet<Polycy> Polycy { get; set; }
        public DbSet<PromotionalCode> PromotionalCode { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomNumber> RoomNumber { get; set; }
        public DbSet<Rooms> Rooms { get; set; }





        #endregion

        public MyDbcontext(DbContextOptions<MyDbcontext> options) : base(options)
        {

        }
    }
}
