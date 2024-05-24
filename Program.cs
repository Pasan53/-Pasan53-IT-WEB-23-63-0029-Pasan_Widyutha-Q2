using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Student_Manageament_System_WebDev.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Student_Manageament_System_WebDevContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Student_Manageament_System_WebDevContext") ?? throw new InvalidOperationException("Connection string 'Student_Manageament_System_WebDevContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
