using System.ComponentModel.DataAnnotations;

namespace WebBookingHotel.Models.EnityVM
{
    public class TaikhoanVM
    {
        [Required(ErrorMessage = "Tên không được để trống")]
        public string fullname { get; set; }
        [Required(ErrorMessage = "Địa chỉ được để trống")]

        public string address { get; set; }
        [Required(ErrorMessage = "Quốc gia được để trống")]

        public string Country { get; set; }
        [Required(ErrorMessage = "Tên đăng nhập được để trống")]

        public string UserName { get; set; }
        [Required(ErrorMessage = "Mật khẩu được để trống")]
        [StringLength(100, ErrorMessage = "Mật khẩu ít nhất 6 ký tự", MinimumLength = 6)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$", ErrorMessage = "Password phải ít nhất 1 chữ hoa,1 chữ thường,1 ký tự đặc biệt")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email không dược để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Nhập lại mật khẩu không được để trống")]
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp")]
        public string EnterPassword { get; set; }
        [Required(ErrorMessage = "Vai trò không được để trống")]
        public string Role { get; set; }

    }
}
