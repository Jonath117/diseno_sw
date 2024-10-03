// este es mi contenedor
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IExaminador>(provider => new Examinador(1, "jonathan,", "jona.rocha@gmail.com", "hola123")); 


// Add services to the container.

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}

app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
