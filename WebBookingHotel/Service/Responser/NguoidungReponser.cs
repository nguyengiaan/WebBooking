using Microsoft.AspNetCore.Identity;
using WebBookingHotel.Data;
using WebBookingHotel.Models.Enitity;
using WebBookingHotel.Models.EnityVM;
using WebBookingHotel.Service.IResponser;

namespace WebBookingHotel.Service.Responser
{
    public class NguoidungReponser : INguoidung
    {
        private readonly MyDbcontext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public NguoidungReponser(MyDbcontext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public async Task<Status> Themtaikhoan(TaikhoanVM taikhoan)
        {
            try
            {
                var Status = new Status();
                var userExist = await _userManager.FindByNameAsync(taikhoan.UserName);
                if (userExist != null)
                {
                    Status.StatusCode = 0;
                    Status.Message = "Tên đăng nhập đã tồn tại";
                    return Status;
                }
                var emailExist = await _userManager.FindByEmailAsync(taikhoan.Email);
                if (emailExist != null)
                {
                    Status.StatusCode = 0;
                    Status.Message = "Email đã tồn tại";
                    return Status;
                }
                var userRegister = new ApplicationUser
                {
                    fullname = taikhoan.fullname,
                    UserName = taikhoan.UserName,
                    Email = taikhoan.Email,
                    address = taikhoan.address,
                    Country = taikhoan.Country,
                    PhoneNumber = taikhoan.Phone,
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                var result = await _userManager.CreateAsync(userRegister, taikhoan.Password);
                if (!result.Succeeded)
                {
                    Status.StatusCode = 0;
                    Status.Message = "Đăng ký thất bại";
                    return Status;
                }
                if (!await _roleManager.RoleExistsAsync(taikhoan.Role))
                {
                    await _roleManager.CreateAsync(new IdentityRole(taikhoan.Role));
                }
                if (await _roleManager.RoleExistsAsync(taikhoan.Role))
                {
                    await _userManager.AddToRoleAsync(userRegister, taikhoan.Role);
                }

                Status.StatusCode = 1;
                Status.Message = "Đăng ký thành công";
                return Status;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return new Status { StatusCode = 0, Message = ex.Message };
            }
            return new Status { StatusCode = 0, Message = "Đăng ký thất bại" };
        }

    }

}
