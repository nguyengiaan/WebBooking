using WebBookingHotel.Models.EnityVM;

namespace WebBookingHotel.Service.IResponser
{
    public interface ILoaiphong
    {
        public Task<Boolean> ThemLoaiphong(LoaiphongVM loaiphong);
        public Task<List<LoaiphongVM>> DanhSachLoaiphong();
    }
}
