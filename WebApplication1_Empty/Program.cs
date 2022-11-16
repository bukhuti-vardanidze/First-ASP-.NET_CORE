var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/", () => "hello post method");
app.MapPost("/ping", () => "hello test method" );

app.Run();