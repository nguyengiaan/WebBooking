using Microsoft.AspNetCore.Mvc;
using WebBookingHotel.Models.EnityVM;
using WebBookingHotel.Service.IResponser;

namespace WebBookingHotel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoaiphongController : Controller
    {
        private readonly ILoaiphong _loaiphong;

        public LoaiphongController(ILoaiphong loaiphong)
        {
            _loaiphong = loaiphong;
        }
        [HttpPost]
        public async Task< IActionResult> Themloaiphong(LoaiphongVM loaiphong)
        {
            try
            {
                var data= await _loaiphong.ThemLoaiphong(loaiphong);
                if(data)
                {
                    return Json(new { success = true, message = "Thêm thành công" });
                }
                else
                {
                    return Json(new { success = false, message = "Thêm thất bại" });
                }
            }
            catch(Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
