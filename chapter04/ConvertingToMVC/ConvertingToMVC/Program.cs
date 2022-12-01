using ConvertingToMVC.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ToDoService>();

var app = builder.Build();

app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();
