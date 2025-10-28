var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// In-memory storage for Magic game sessions
var magicGameSessions = new Dictionary<Guid, MagicGameSession>();

app.MapGet("/hello", () => "Hello, .NET 9!");

app.MapPost("/users", (User user) =>
{
    return Results.Created($"/users/{user.Id}", user);
});

// Create a new Magic game session
app.MapPost("/magic-sessions", (MagicGameSession session) =>
{
    var sessionId = Guid.NewGuid();
    session.StartTime = DateTime.UtcNow;
    magicGameSessions[sessionId] = session;
    return Results.Created($"/magic-sessions/{sessionId}", new { Id = sessionId, Session = session });
});

// Get a Magic game session by ID
app.MapGet("/magic-sessions/{id:guid}", (Guid id) =>
{
    if (magicGameSessions.TryGetValue(id, out var session))
    {
        return Results.Ok(session);
    }
    return Results.NotFound();
});

// Get all Magic game sessions
app.MapGet("/magic-sessions", () =>
{
    return Results.Ok(magicGameSessions);
});

app.Run();

record User(int Id, string Name);
