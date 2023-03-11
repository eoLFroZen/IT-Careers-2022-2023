using Microsoft.EntityFrameworkCore;
using Product_Web_App.Data;
using Product_Web_App.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationContext>(c => c.UseMySQL("Server=localhost;Database=myDataBase;Uid=root;Pwd=1234;"));
//builder.Services.AddDbContext<ApplicationContext>(c => c.UseSqlServer("Server=localhost;Database=test;Trusted_Connection=True;"));

builder.Services.AddScoped<ProductService, ProductService>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();
