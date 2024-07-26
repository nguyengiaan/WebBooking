/*using Microsoft.AspNetCore.Mvc;
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
                    return RedirectToAction("Index", "Home");
                    // return RedirectToAction("Booking", "Home");
                    //return Json(new { success = true, message = "Đăng ký thành công", redirectUrl = Url.Action("Booking", "Home") });
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

*/
/*using Microsoft.AspNetCore.Mvc;
using WebBookingHotel.Models.EnityVM;
using WebBookingHotel.Service.IResponser;
using Microsoft.AspNetCore.Identity;
using WebBookingHotel.Models.Enitity;

namespace WebBookingHotel.Controllers
{
    public class NguoidungController : Controller
    {
        private readonly INguoidung _nguoidung;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public NguoidungController(INguoidung nguoidung, SignInManager<ApplicationUser> signInManager)
        {
            _nguoidung = nguoidung;
            _signInManager = signInManager;
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
                var data = await _nguoidung.Themtaikhoan(taikhoan);
                if (data.StatusCode == 1)
                {
                    var user = await _signInManager.UserManager.FindByNameAsync(taikhoan.UserName);
                    if (user != null)
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                    }

                    // Chuyển hướng đến trang Index của Home controller
                    return RedirectToAction("Booking", "Home");
                }
                else
                {
                    return Json(new { success = false, message = data.Message });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
*/
using Microsoft.AspNetCore.Mvc;
using WebBookingHotel.Models.EnityVM;
using WebBookingHotel.Service.IResponser;
using Microsoft.AspNetCore.Identity;
using WebBookingHotel.Models.Enitity;

namespace WebBookingHotel.Controllers
{
    public class NguoidungController : Controller
    {
        private readonly INguoidung _nguoidung;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public NguoidungController(INguoidung nguoidung, SignInManager<ApplicationUser> signInManager)
        {
            _nguoidung = nguoidung;
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Dangkythanhvien(TaikhoanVM taikhoan)
        {
            try
            {
                var errorList = ModelState.Values.SelectMany(m => m.Errors).Select(e => e.ErrorMessage).ToList();
                if (!ModelState.IsValid)
                {
                    return Json(new { success = false, message = string.Join(" ", errorList) });
                }
                var data = await _nguoidung.Themtaikhoan(taikhoan);
                if (data.StatusCode == 1)
                {
                    return Json(new { success = true, message = "Đăng ký thành công" });
                }
                else
                {
                    return Json(new { success = false, message = data.Message });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
        public IActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        /*   public async Task<IActionResult> Dangnhap(DangnhapVM dangnhap)
           {
               if (!ModelState.IsValid)
               {
                   return RedirectToAction("Signin", "Home"); // Redirect back to the signin view if the model is invalid
               }

               var result = await _signInManager.PasswordSignInAsync(dangnhap.UserName, dangnhap.Password, dangnhap.RememberMe, false);

               if (result.Succeeded)
               {
                   ViewData["SuccessMessage"] = "Đăng nhập thành công!";
                   return RedirectToAction("Booking", "Home"); // Redirect to Home/Index after successful login
               }
               else
               {
                   ModelState.AddModelError(string.Empty, "Đăng nhập không thành công. Vui lòng kiểm tra lại tài khoản hoặc mật khẩu.");
                   return RedirectToAction("Signin", "Home"); // Redirect back to the signin view if login fails
               }
           }
        */
        [HttpPost]
        public async Task<IActionResult> Dangnhap(DangnhapVM dangnhap)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { success = false, message = "Dữ liệu không hợp lệ." });
            }

            var result = await _signInManager.PasswordSignInAsync(dangnhap.UserName, dangnhap.Password, dangnhap.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return Json(new { success = true, message = "Đăng nhập thành công!" });
            }
            else
            {
                return Json(new { success = false, message = "Đăng nhập không thành công. Vui lòng kiểm tra lại tài khoản hoặc mật khẩu." });
            }
        }


        [HttpPost]
        public async Task<IActionResult> Dangxuat()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Booking", "Home");
        }

    }
}
