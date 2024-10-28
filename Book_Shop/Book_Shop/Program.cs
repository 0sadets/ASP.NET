using DataAccess;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;
using FluentValidation;
using Book_Shop.Services;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

string connString = builder.Configuration.GetConnectionString("RemoteDb")!;
builder.Services.AddDbContext<ShopDbContext>(opt => opt.UseSqlServer(connString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ShopDbContext>();

//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//    .AddEntityFrameworkStores<ShopDbContext>()
//    .AddDefaultTokenProviders();

//builder.Services.AddTransient<ShopDbContext>();
// add fluent validators
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());


// add custom services
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddSession(options =>
{
    //options.IdleTimeout = TimeSpan.FromDays(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();




app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.UseSession();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
