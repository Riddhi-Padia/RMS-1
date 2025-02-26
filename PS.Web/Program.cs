using Microsoft.EntityFrameworkCore;
using PS.Service.Interface;
using PS.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
    //db connection
var com = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PS.Domain.Data_Models.PizzaShopDbContext>(q=> q.UseNpgsql(com));
    //email service
builder.Services.Configure<PS.Domain.View_Models.EmailData>(builder.Configuration.GetSection("EmailData"));
builder.Services.AddScoped<IEmailService, EmailService>();

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
