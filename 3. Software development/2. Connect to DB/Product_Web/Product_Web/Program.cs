using Microsoft.EntityFrameworkCore;
using Product_Web_App.Data;
using Product_Web_App.Services;
using Product_Web.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Product_Web.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = 
    builder.Configuration.GetConnectionString("ApplicationContextConnection") ?? 
    throw new InvalidOperationException("Connection string 'ApplicationContextConnection' not found.");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationContext>(c => 
    c.UseMySQL(connectionString));

builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredUniqueChars = 2;
    options.Password.RequireDigit = false;
    options.Password.RequireUppercase = false;
})
    .AddEntityFrameworkStores<ApplicationContext>();

builder.Services.AddScoped<ProductService, ProductService>();
builder.Services.AddScoped<UserService, UserService>();

builder.Services.AddRazorPages();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
