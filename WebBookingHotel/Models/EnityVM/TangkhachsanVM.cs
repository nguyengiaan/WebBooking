using System.ComponentModel.DataAnnotations;

namespace WebBookingHotel.Models.EnityVM
{
    public class TangkhachsanVM
    {
        public string? Ma_Tang { get; set; }
        [Required(ErrorMessage = "Tên tầng không được để trống")]
        public string Ten_Tang { get; set; }

        [Required(ErrorMessage = "Tổng số phòng của tầng không được để trống")]
        public int Sophong { get; set; }
        [Required(ErrorMessage = "Ghi chú của tầng không được để trống")]
        public string Ghichu { get; set; }
        [Required(ErrorMessage = "Trạng thái của tầng không được để trống")]
        public string Trangthai { get; set; }

        public string? Ma_Khachsan { get; set; }

        public string? Ten_Khachsan { get; set; }

    }
}
