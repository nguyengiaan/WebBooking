using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebBookingHotel.Data;
using WebBookingHotel.Models.Enitity;
using WebBookingHotel.Service.IResponser;
using WebBookingHotel.Service.Responser;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyDbcontext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlServerOptionsAction: sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5, // Số lần thử lại tối đa
                maxRetryDelay: TimeSpan.FromSeconds(30), // Thời gian chờ tối đa giữa các lần thử lại
                errorNumbersToAdd: null); // Có thể chỉ định mã lỗi cụ thể để thử lại
        }));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<MyDbcontext>().AddDefaultTokenProviders();
builder.Services.AddScoped<IKhachsan, KhachsanReponser>();
builder.Services.AddScoped<INguoidung, NguoidungReponser>();
builder.Services.AddScoped<ITangkhachsan, TangkhachsanReponser>();
builder.Services.AddScoped<ILoaiphong, LoaiphongReponser>();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=TrangchuAdmin}/{action=Index}/{id?}"
    );
    endpoints.MapControllerRoute(
      name: "default",
      pattern: "{controller=Home}/{action=Index}/{id?}"
    );
});
app.Run();
