var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();
app.MapGet("/", () => "Hello World 444444!");
app.MapGet("/dd", () => "Hello from dd");
app.Run();
