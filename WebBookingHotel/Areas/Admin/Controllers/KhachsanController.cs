﻿using Microsoft.AspNetCore.Mvc;
using WebBookingHotel.Models.Enitity;
using WebBookingHotel.Models.EnityVM;
using WebBookingHotel.Service.IResponser;

namespace WebBookingHotel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KhachsanController : Controller
    {
        private readonly IKhachsan _khachsan;

        public KhachsanController(IKhachsan khachsan)
        {
            _khachsan = khachsan;
        }
        [HttpPost]
        public async Task<IActionResult> Themkhachsan(KhachsanVM khachsan)
        {
            try
            {
                var errorList = ModelState.Values.SelectMany(m => m.Errors).Select(e => e.ErrorMessage).ToList();
                if (!ModelState.IsValid)
                {
                    return Json(new { success = false, message = errorList });
                }
                var ketqua= await _khachsan.ThemKhachsans(khachsan);
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

        [HttpGet]
        public async Task<IActionResult> Danhsachkhachsan()
        {
            try
            {
                var data = await _khachsan.DanhSachKhachsan();
                if(data != null)
                {
                    return Json(new { success = true, data = data });
                }
                else
                {
                    return Json(new { success = false, message = "Không có dữ liệu" });
                }
            }
            catch(Exception ex)
            {
                 return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
