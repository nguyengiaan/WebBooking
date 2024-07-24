using WebBookingHotel.Models.EnityVM;

namespace WebBookingHotel.Service.IResponser
{
    public interface ITangkhachsan
    {
        public Task<Boolean> ThemTangkhachsan(TangkhachsanVM tangkhachsan);
        public Task<List<TangkhachsanVM>> DanhSachTangkhachsan();
    }
}
