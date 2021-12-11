var builder = WebApplication.CreateBuilder(args); //Создаем построитель приложения(объект)

#region Настройка построителя приложения - определение содержимого
//Получили сервисы
var services = builder.Services; //Коллекция сервисов нашего приложения
services.AddControllersWithViews(); // Подключили структуру MVC
#endregion

var app = builder.Build(); //Билдер строит наше приложение(Сборка приложения)

// Загрузка информации из файла конфигурации
//var configuration = app.Configuration;
//var greetings = configuration["CustomGreetings"];

//Конвейер обработки входного соединения
#region Конфигурирование конфейера обработки входящих соединений
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); //Инструмент, который позволяет перехватывать все ошибки
}

app.UseRouting(); //Добавление системы маршрутизации

//app.MapGet("/", () => app.Configuration["CustomGreetings"]);
app.MapGet("/throw", () => { throw new ApplicationException("Ошибка в программе!"); });

//app.MapDefaultControllerRoute(); //Добавляем обработку входящих соединений системой MVC
//Маршрут - адресс, который мы вводим в адресную строку браузера

app.MapControllerRoute(
    name: "default",
    pattern: "/{controller=Home}/{action=Index}/{id?}");

#endregion

app.Run(); //Приложение стартует и начинает принимать входящие запросы

