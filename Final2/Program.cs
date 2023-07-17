using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Final2.Data;
using MongoDB.Driver.Core.Configuration;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);


//esse peguei do tutorial da ms
builder.Services.AddDbContext<Final2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Final2Context")));

//essas duas loinhas debaixo adrian fez pra conectar no mysql
/*var connectionString = builder.Configuration.GetConnectionString("Final2Context");
builder.Services.AddDbContext<Final2Context>(); */


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
