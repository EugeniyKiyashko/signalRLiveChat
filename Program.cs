using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// Создание и настройка хоста
var builder = WebApplication.CreateBuilder(args);

// Настройка служб
builder.Services.AddSignalR();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyHeader()
              .AllowAnyMethod()
.WithOrigins("http://localhost:8080", "http://10.211.55.3/") // Замените на ваш адрес клиента
              .AllowCredentials();
    });
});

var app = builder.Build();

app.UseRouting();
app.UseCors();

app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<ChatHub>("/chathub");
});

app.Run();