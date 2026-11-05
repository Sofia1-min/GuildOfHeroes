public class Game {
    public string Title;
    public string Genre;
    public int ReleaseYear;
    public double Rating;
    public int PlayTime; 

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