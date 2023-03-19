using Microsoft.EntityFrameworkCore;
using Product_Web_App.Data;
using Product_Web_App.Services;
using Product_Web.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Product_Web.Services;
using Product_Web.Services.Interfaces;
using Product_Web.Repositories.Interfaces;
using Product_Web.Repositories;
using Product_Web.Data;

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

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IUserService, UserService>();

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
Seed.SeedData(app);

app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();