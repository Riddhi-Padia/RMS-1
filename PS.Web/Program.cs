using Microsoft.EntityFrameworkCore;
using PS.Infrastructure.Interface;
using PS.Infrastructure.Implementation;
using PS.Service.Implementation;
using PS.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var com = builder.Configuration.GetConnectionString("DefaultConnection");

//Register dbContext
builder.Services.AddDbContext<PS.Domain.Data_Models.PizzaShopDbContext>(q=> q.UseNpgsql(com));

// Register Repository
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Register Service
builder.Services.AddScoped<IUserService, UserService>();

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
