using Microsoft.EntityFrameworkCore;
using TumisugiApp.Data;

var builder = WebApplication.CreateBuilder(args);

#region SQLiteへの接続
// SQLite配置dir
var dataDir = Path.Combine(AppContext.BaseDirectory, "Data");
Directory.CreateDirectory(dataDir);

// appsetting.jsonの接続文字列取得
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")?
                        .Replace("tumisugi.db", Path.Combine(dataDir, "tumisugi.db"));

// DbContextに接続文字列を渡す
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(connectionString));

#endregion

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/TumiList/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=TumiList}/{action=Index}/{id?}");

app.Run();
