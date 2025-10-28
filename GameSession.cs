namespace MinimalApi;

/// <summary>
/// Represents a gaming session with its participants and state
/// </summary>
public class GameSession
{
    /// <summary>
    /// Unique identifier for the game session
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Name of the game session
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Date and time when the session started
    /// </summary>
    public DateTime StartTime { get; set; }

    /// <summary>
    /// Date and time when the session ended (null if still active)
    /// </summary>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Current status of the game session
    /// </summary>
    public GameSessionStatus Status { get; set; }

    /// <summary>
    /// List of player names participating in the session
    /// </summary>
    public List<string> Players { get; set; } = new();

    /// <summary>
    /// Maximum number of players allowed in the session
    /// </summary>
    public int MaxPlayers { get; set; }

    /// <summary>
    /// Current score or points in the game
    /// </summary>
    public int Score { get; set; }

    /// <summary>
    /// Checks if the session is currently active
    /// </summary>
    public bool IsActive => Status == GameSessionStatus.Active;

    /// <summary>
    /// Gets the duration of the game session
    /// </summary>
    public TimeSpan Duration => (EndTime ?? DateTime.UtcNow) - StartTime;
}

/// <summary>
/// Enumeration of possible game session statuses
/// </summary>
public enum GameSessionStatus
{
    /// <summary>
    /// Session is waiting for players
    /// </summary>
    Waiting,

    /// <summary>
    /// Session is currently active
    /// </summary>
    Active,

    /// <summary>
    /// Session is paused
    /// </summary>
    Paused,

    /// <summary>
    /// Session has completed
    /// </summary>
    Completed,

    /// <summary>
    /// Session was cancelled
    /// </summary>
    Cancelled
}
