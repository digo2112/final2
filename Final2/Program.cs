using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Final2.Data;
using MongoDB.Driver.Core.Configuration;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);



/*builder.Services.AddDbContext<Final2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Final2Context") ?? throw new InvalidOperationException("Connection string 'Final2Context' not found.")));*/



//var serverVersion = new MySqlServerVersion(new Version(8, 0, 32));
//var connectionString = new MySqlServerVersion(new Version(8, 0, 32));
var connectionString = builder.Configuration.GetConnectionString("Final2Context");

//Version connectionString = new MySqlServerVersion(new Version(8, 0, 32));//new Version(8, 0, 32);
//NAO CONSEGUI USAR O AUTODETECT

//string? connectionString = builder.Configuration.GetConnectionString("Final2");

builder.Services.AddDbContext<Final2Context>(); 
// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
