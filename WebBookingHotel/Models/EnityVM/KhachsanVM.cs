using System.ComponentModel.DataAnnotations;

namespace WebBookingHotel.Models.EnityVM
{
    public class KhachsanVM
    {
        public string? Ma_Khachsan { get; set; }
        [Required(ErrorMessage = "Tên khách sạn không được để trống")]
        public string Ten_Khachsan { get; set; }
        [Required(ErrorMessage = "Số lượng tầng không được để trống")]

        public int Soluongtang { get; set; }

        [Required(ErrorMessage = "Số lượng phòng không được để trống")]
        public int Soluongphong { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Diachi { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string SDT { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage ="Địa chỉ email không hợp lệ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Website không được để trống")]
        public string Website { get; set; }
        [Required(ErrorMessage = "Ghi chú không được để trống")]
        public string Ghichu { get; set; }
        [Required(ErrorMessage = "Ngày tạo không được để trống")]
        public DateTime ngaytao { get; set; }
        public string? Id { get; set; }
    }
}
