using Microsoft.AspNetCore.Mvc;

namespace WebBookingHotel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TrangchuAdminController : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Danhsachkhachsan()
        {
            return View();
        }

        public IActionResult Quanlynguoidung()
        {
            return View();
        }
        public IActionResult Danhsachlautang()
        {
            return View();
        }
        public IActionResult Danhsachloaiphong()
        {
            return View();
        }
    }
}
