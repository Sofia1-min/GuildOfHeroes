public class Game {
    private string _title = "Без названия";
    public string Title {
        get { return _title; }
        private set {
            if (string.IsNullOrWhiteSpace(value)) {
                _title = "Без названия";
                return;
            }
            _title = value.Trim();
        }
    }

    public string Genre;
    public int ReleaseYear;

    private double _rating;
    public double Rating {
        get { return _rating; }
        private set {
            if (value < 0) _rating = 0;
            else if (value > 10) _rating = 10;
            else _rating = value;
        }
    }

    public int PlayTime { get; private set; }

    public Game(string title, string genre, int releaseYear) {
        Title = title;
        Genre = genre;
        ReleaseYear = releaseYear;
        Rating = 0;
        PlayTime = 0;
    }

    public void AddPlayTime(int hours) {
        if (hours <= 0) {
            return;
        }
        PlayTime += hours;
    }

    public void ChangeRating(double newRating) {
        Rating = newRating;
    }
}

public class GameCatalog
{
    private List<Game> _games = new List<Game>();

    public int Count => _games.Count;

    public bool AddGame(Game game)
    {
        if (FindByTitle(game.Title) != null) return false;
        _games.Add(game);
        return true;
    }

    public Game? FindByTitle(string title)
    {
        if (string.IsNullOrWhiteSpace(title)) return null;
        string search = title.Trim();
        foreach (Game g in _games)
        {
            if (string.Equals(g.Title, search, StringComparison.OrdinalIgnoreCase)) return g;
        }
        return null;
    }

    public bool RemoveGame(string title)
    {
        Game? g = FindByTitle(title);
        if (g == null) return false;
        return _games.Remove(g);
    }

    public List<Game> GetGames()
    {
        List<Game> copy = new List<Game>();
        foreach (Game g in _games) copy.Add(g);
        return copy;
    }

    public int CountHighRated(double minRating)
    {
        int count = 0;
        foreach (Game g in _games)
        {
            if (g.Rating >= minRating) count++;
        }
        return count;
    }

}
public class GameSession
{
    public int Number { get; private set; }
    public Game? TargetGame { get; private set; }
    public bool IsFinished { get; private set; }

    public GameSession(int number)
    {
        Number = number;
        TargetGame = null;
        IsFinished = false;
    }

    public bool TryStart(Game game)
    {
        if (IsFinished) return false;
        if (TargetGame != null) return false;

        TargetGame = game;
        return true;
    }

    public bool TryFinish(int hoursPlayed)
    {
        if (IsFinished) return false;
        if (TargetGame == null) return false;
        if (hoursPlayed <= 0) return false;

        TargetGame.AddPlayTime(hoursPlayed);
        IsFinished = true;
        return true;
    }
}