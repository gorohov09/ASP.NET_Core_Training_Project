var builder = WebApplication.CreateBuilder(args);

//Получили сервисы
var services = builder.Services;
services.AddControllersWithViews(); // Подключили структуру MVC

var app = builder.Build();

// Загрузка информации из файла конфигурации
//var configuration = app.Configuration;
//var greetings = configuration["CustomGreetings"];

//Конвейер обработки входного соединения

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); //Инструмент, который позволяет перехватывать все ошибки
}

app.UseRouting(); //Добавление системы маршрутизации

//app.MapGet("/", () => app.Configuration["CustomGreetings"]);
app.MapGet("/throw", () => { throw new ApplicationException("Ошибка в программе!"); });

app.MapDefaultControllerRoute(); //Добавляем обработку входящих соединений системой MVC



app.Run();

