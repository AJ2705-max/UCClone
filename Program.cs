

using UrbanClapClone.Extension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.PropertyNamingPolicy = null); //**Added Manually

builder.Services.AddAppSetting(); // **Added Manually 

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
    //pattern: "{controller=Home}/{action=Index}/{id?}");
  //pattern: "{controller=User}/{action=Register}/{id?}");
  pattern: "{controller=UserHomePage}/{action=UserDashboard}/{id?}");

//pattern: "{controller=Admin}/{action=Register}/{id?}");

app.Run();
