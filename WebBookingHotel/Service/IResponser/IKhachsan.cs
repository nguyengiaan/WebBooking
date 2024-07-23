using WebBookingHotel.Models.Enitity;
using WebBookingHotel.Models.EnityVM;

namespace WebBookingHotel.Service.IResponser
{
    public interface IKhachsan
    {
        public Task<Boolean> ThemKhachsans(KhachsanVM khachsan);
    }
}
