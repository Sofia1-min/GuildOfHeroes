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
    public double Rating;


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
}