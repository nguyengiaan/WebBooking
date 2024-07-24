using System.ComponentModel.DataAnnotations;

namespace WebBookingHotel.Models.EnityVM
{
    public class LoaiphongVM
    {
        public string? Ma_LoaiPhong { get; set; }
        [Required(ErrorMessage = "Tên loại phòng không được để trống")]
        public string Ten_loaiphong { get; set; }
        [Required(ErrorMessage = "Số giường không được để trống")]
        public int Sogiuong { get; set; }
        [Required(ErrorMessage = "Số người không được để trống")]
        public int Songuoi { get; set; }
        [Required(ErrorMessage = "Giá theo ngày không được để trống")]

        public int Giatheongay { get; set; }
        [Required(ErrorMessage = "Giá theo giờ không được để trống")]
        public int Giatheogio { get; set; }
        [Required(ErrorMessage = "Giá theo tháng không được để trống")]

        public int Giatheothang { get; set; }

        [Required(ErrorMessage = "Ghi chú không được để trống")]
        public string Ghichu { get; set; }
    }
}
