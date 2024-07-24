
using Microsoft.AspNetCore.Mvc;
using WebBookingHotel.Models.EnityVM;
using WebBookingHotel.Service.IResponser;

namespace WebBookingHotel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TangkhachsanController : Controller
    {
        private readonly ITangkhachsan _tangkhachsan;

        public TangkhachsanController(ITangkhachsan tangkhachsan)
        {
            _tangkhachsan = tangkhachsan;
        }
        [HttpGet]
        public async Task<IActionResult> Danhsachtang()
        {
            try
            {
                var data = await _tangkhachsan.DanhSachTangkhachsan();
                if (data != null)
                {
                    return Json(new { success = true, data = data });
                }
                else
                {
                    return Json(new { success = false, message = "Không có dữ liệu" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }   
        }
        [HttpPost]
        public async Task<IActionResult> Themtang(TangkhachsanVM tangkhachsan)
        {
            try
            {
                var errorList = ModelState.Values.SelectMany(m => m.Errors).Select(e => e.ErrorMessage).ToList();
                if (!ModelState.IsValid)
                {
                    return Json(new { success = false, message = errorList });
                }
                var ketqua = await _tangkhachsan.ThemTangkhachsan(tangkhachsan);
                if (ketqua)
                {
                    return Json(new { success = true, message = "Thêm thành công" });
                }
                else
                {
                    return Json(new { success = false, message = "Thêm thất bại" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
