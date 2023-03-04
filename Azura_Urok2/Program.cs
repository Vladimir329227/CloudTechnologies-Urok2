var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async (context) =>
{
    var Data = new { Text = "Все работает, вроде" , Time = DateTime.Now };
    await context.Response.WriteAsJsonAsync(Data);
});

app.MapGet("/ping", async (context) =>
{
    var Data = new { Text = "Pong" };
    await context.Response.WriteAsJsonAsync(Data);
});

app.MapGet("/info", async (context) =>
{
    var Data = new { ProcessorCount = Environment.ProcessorCount , VersionString = Environment.OSVersion.VersionString,Time = DateTime.Now };
    await context.Response.WriteAsJsonAsync(Data);
});

app.Run();
