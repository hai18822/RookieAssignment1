using AssigmentMVC.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseLoggingMiddleware();
app.Run();
