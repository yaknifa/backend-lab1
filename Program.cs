var builder = WebApplication.CreateBuilder(args); // создание конфигурации для приложения
var app = builder.Build(); // создание приложения

app.UseStaticFiles(); // использование статических файлов (html, php, css) для сайтов

app.MapGet("/", () => "Манюшки :3"); // обработчик get-запроса
app.MapGet("/omgismagis", () => "ОГО ОНО ЧТО РЕАЛЬНО РАБОТАЕТ"); // ещё один обработчик get-запроса

app.Run(); // запуск
