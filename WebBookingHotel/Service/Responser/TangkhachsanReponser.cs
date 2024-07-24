using Microsoft.EntityFrameworkCore;
using WebBookingHotel.Data;
using WebBookingHotel.Models.Enitity;
using WebBookingHotel.Models.EnityVM;
using WebBookingHotel.Service.IResponser;

namespace WebBookingHotel.Service.Responser
{
    public class TangkhachsanReponser : ITangkhachsan
    {
        private readonly MyDbcontext _context;

        public TangkhachsanReponser(MyDbcontext context)
        {
            _context=context;
        }   
        public Task<List<TangkhachsanVM>> DanhSachTangkhachsan()
        {
            try
            {
                var data = _context.Tangkhachsan.Select(x => new TangkhachsanVM()
                {
                    Ma_Tang = x.Ma_Tang,
                    Ten_Tang = x.Ten_Tang,
                    Sophong = x.Sophong,
                    Ghichu = x.Ghichu,
                    Trangthai = x.Trangthai,
                    Ma_Khachsan = x.Ma_Khachsan,
                    Ten_Khachsan = x.Khachsan.Ten_Khachsan


                }).ToListAsync();
                return data;
            } 
            catch (Exception ex)
            {
                return null;
            }
            
        }

        public async Task<Boolean> ThemTangkhachsan(TangkhachsanVM tangkhachsan)
        {
            try
            {
                var lastMaDV = await _context.Tangkhachsan
                      .OrderByDescending(x => x.Ma_Tang)
                      .Select(x => x.Ma_Tang)
                      .FirstOrDefaultAsync();
                int nextNumber = 1;
                if (lastMaDV != null)
                {
                    nextNumber = int.Parse(lastMaDV.Substring(4)) + 1;
                }
                Tangkhachsan tangkhachsan1 = new Tangkhachsan();
                tangkhachsan1.Ma_Tang = "MATG" + nextNumber;
                tangkhachsan1.Ten_Tang = tangkhachsan.Ten_Tang;
                tangkhachsan1.Sophong = tangkhachsan.Sophong;
                tangkhachsan1.Ghichu = tangkhachsan.Ghichu;
                tangkhachsan1.Trangthai = tangkhachsan.Trangthai;
                tangkhachsan1.Ma_Khachsan = tangkhachsan.Ma_Khachsan;
                await _context.Tangkhachsan.AddAsync(tangkhachsan1);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
