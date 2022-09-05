var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(options => options.MaxModelValidationErrors = 400);
var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();