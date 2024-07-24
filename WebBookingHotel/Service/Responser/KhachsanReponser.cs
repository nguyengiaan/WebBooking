using WebBookingHotel.Models.EnityVM;
using WebBookingHotel.Service.IResponser;
using WebBookingHotel.Models.Enitity;
using Microsoft.EntityFrameworkCore;
using WebBookingHotel.Data;

namespace WebBookingHotel.Service.Responser
{
    public class KhachsanReponser : IKhachsan
    {
        private readonly MyDbcontext _context;

        public KhachsanReponser(MyDbcontext context)
        {
            _context = context;
        }

        public async Task<List<KhachsanVM>> DanhSachKhachsan()
        {
            try 
            {
                List<KhachsanVM> khachsan = await _context.Khachsan.Select(x => new KhachsanVM()
                {
                    Ma_Khachsan = x.Ma_Khachsan,
                    Ten_Khachsan = x.Ten_Khachsan,
                    Soluongtang = x.Soluongtang,
                    Soluongphong = x.Soluongphong,
                    Diachi = x.Diachi,
                    SDT = x.SDT,
                    Email = x.Email,
                    Website = x.Website,
                    Ghichu = x.Ghichu,
                    ngaytao = x.ngaytao,
                    Id = x.Id
                }).ToListAsync();
                return khachsan;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public async Task<Boolean> ThemKhachsans(KhachsanVM khachsan)
        {
            try
            {
                Khachsan khachsan1 = new Khachsan();
                var lastMaDV = await _context.Khachsan
                      .OrderByDescending(x => x.Ma_Khachsan)
                      .Select(x => x.Ma_Khachsan)
                      .FirstOrDefaultAsync();
                int nextNumber = 1;
                if (lastMaDV != null)
                {
                    nextNumber = int.Parse(lastMaDV.Substring(4)) + 1;
                }
                khachsan1.Ma_Khachsan = "MAKS"+nextNumber;
                khachsan1.Ten_Khachsan = khachsan.Ten_Khachsan;
                khachsan1.Soluongtang = khachsan.Soluongtang;
                khachsan1.Soluongphong = khachsan.Soluongphong;
                khachsan1.Diachi = khachsan.Diachi;
                khachsan1.SDT = khachsan.SDT;
                khachsan1.Email = khachsan.Email;
                khachsan1.Website = khachsan.Website;
                khachsan1.Ghichu = khachsan.Ghichu;
                khachsan1.ngaytao = khachsan.ngaytao;
                khachsan1.Id = khachsan.Id;
                await _context.Khachsan.AddAsync(khachsan1);
                await _context.SaveChangesAsync();
                return true;


            }
            catch(Exception ex)
            {
                return false;
            }

        }

        
    }
}
