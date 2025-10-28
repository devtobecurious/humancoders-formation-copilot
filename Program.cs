var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/hello", () => "Hello, .NET 9!");

app.MapPost("/users", (User user) =>
{
    return Results.Created($"/users/{user.Id}", user);
});

app.Run();

record User(int Id, string Name);
