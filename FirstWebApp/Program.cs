using FirstWebApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register MVC
builder.Services.AddControllersWithViews();

// ✅ Register DbContext with DI
builder.Services.AddDbContext<MyDbContext>(options =>
{
    options.UseSqlServer(@"Server=ITV-LAP-0005\SQLEXPRESS;
                           Database=PosDb;
                           Trusted_Connection=True;
                           TrustServerCertificate=True;");
});

var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Default MVC route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
