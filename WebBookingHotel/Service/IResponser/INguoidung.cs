using WebBookingHotel.Models.EnityVM;

namespace WebBookingHotel.Service.IResponser
{
    public interface INguoidung
    {
        public Task<Status> Themtaikhoan(TaikhoanVM taikhoan);
    }
}
