using LibrarySystem.Data.Context;
using LibrarySystem.Logic.Services;
using LibrarySystem.Logic.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllers();
builder.Services.AddDbContext<LibrarySystemDbContext>(options =>
{
    options.UseSqlServer(connectionString, options =>
    {
        options.CommandTimeout(99999);
        options.MigrationsAssembly("LibrarySystem.Data");
        options.EnableRetryOnFailure();
    });
});

builder.Services.AddTransient<IBookService, BookService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<ISubCategoryService, SubCategoryService>();
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

using (var scope = app.Services.CreateScope())
{
    using (var appContext = scope.ServiceProvider.GetRequiredService<LibrarySystemDbContext>())
    {
        try
        {
            appContext.Database.Migrate();
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}

app.Run();
