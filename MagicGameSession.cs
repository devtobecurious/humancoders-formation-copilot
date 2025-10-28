// Magic: The Gathering game session with specific properties for this card game
public class MagicGameSession : GameSession
{
    public string Format { get; set; } = string.Empty;
    public int NumberOfPlayers { get; set; }
    public int StartingLifePoints { get; set; }

    public MagicGameSession()
    {
        NumberOfPlayers = 2;
        StartingLifePoints = 20;
        Format = "Standard";
    }
}
