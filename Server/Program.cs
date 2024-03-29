using Microsoft.AspNetCore.ResponseCompression;
using GimnasioApp.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using GimnasioApp.Repositories.Implementaciones;
using GimnasioApp.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTransient<IMembresiaRepository, MembresiaRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();

builder.Services.AddDbContext<GimnasioAppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("GimnasioAppDb"));
});
// Add services to the container.

//builder.Services.AddControllersWithViews();
//builder.Services.AddRazorPages();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


//app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
