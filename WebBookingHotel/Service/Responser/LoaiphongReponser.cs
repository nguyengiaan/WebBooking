
using Microsoft.EntityFrameworkCore;
using WebBookingHotel.Data;
using WebBookingHotel.Models.Enitity;
using WebBookingHotel.Models.EnityVM;
using WebBookingHotel.Service.IResponser;

namespace WebBookingHotel.Service.Responser
{
    public class LoaiphongReponser : ILoaiphong
    {
        private readonly MyDbcontext _context;

        public LoaiphongReponser(MyDbcontext context)
        {
            _context = context;
        }
        public async Task<Boolean> ThemLoaiphong(LoaiphongVM loaiphong)
        {
            try
            {
                var lastMaDV = await _context.Loaiphong
                    .OrderByDescending(x => x.Ma_LoaiPhong)
                    .Select(x => x.Ma_LoaiPhong)
                    .FirstOrDefaultAsync();
                int nextNumber = 1;
                if (lastMaDV != null)
                {
                    nextNumber = int.Parse(lastMaDV.Substring(4)) + 1;
                }
                Loaiphong loaiphong1 = new Loaiphong();
                loaiphong1.Ma_LoaiPhong = "MALP" + nextNumber;
                loaiphong1.Ten_loaiphong= loaiphong.Ten_loaiphong;
                loaiphong1.Sogiuong = loaiphong.Sogiuong;
                loaiphong1.Songuoi = loaiphong.Songuoi;
                loaiphong1.Giatheongay = loaiphong.Giatheongay;
                loaiphong1.Giatheogio = loaiphong.Giatheogio;
                loaiphong1.Giatheothang = loaiphong.Giatheothang;
                loaiphong1.Ghichu = loaiphong.Ghichu;
                await _context.Loaiphong.AddAsync(loaiphong1);
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public async Task<List<LoaiphongVM>> DanhSachLoaiphong()
        {
            try
            {
                  var data=await _context.Loaiphong.Select(x => new LoaiphongVM()
                  {
                      Ma_LoaiPhong = x.Ma_LoaiPhong,
                      Ten_loaiphong = x.Ten_loaiphong,
                      Sogiuong = x.Sogiuong,
                      Songuoi = x.Songuoi,
                      Giatheongay = x.Giatheongay,
                      Giatheogio = x.Giatheogio,
                      Giatheothang = x.Giatheothang,
                      Ghichu = x.Ghichu
                  }).ToListAsync();
                return data;
            }
            catch(Exception ex )
            {
                return null;
            }
        }
    }
}
