using Microsoft.AspNetCore.Mvc;
using WebBookingHotel.Models.EnityVM;
using WebBookingHotel.Service.IResponser;

namespace WebBookingHotel.Controllers
{
    public class NguoidungController : Controller
    {
        private readonly INguoidung _nguoidung;

        public NguoidungController(INguoidung nguoidung)
        {
            _nguoidung = nguoidung;
        }
        [HttpPost]
        public async Task<IActionResult> Dangkythanhvien(TaikhoanVM taikhoan)
        {
            try
            {
                var errorList = ModelState.Values.SelectMany(m => m.Errors).Select(e => e.ErrorMessage).ToList();
                if (!ModelState.IsValid)
                {
                    return Json(new { success = false, message = errorList });
                }
                var data= await _nguoidung.Themtaikhoan(taikhoan);
                if (data.StatusCode == 1)
                {
                    return Json(new { success = true, message = "Đăng ký thành công" });
                }
                else
                {
                    return Json(new { success = false, message = data.Message });
                }
            }
            catch(Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
