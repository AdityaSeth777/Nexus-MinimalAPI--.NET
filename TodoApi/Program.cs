var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/todo", () => new { Item = "Water plants", Complete = "false" });
app.Run();
