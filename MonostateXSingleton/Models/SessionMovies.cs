namespace MonostateXSingleton.Models;

public class SessionMovies
{
    public SessionMovies(IEnumerable<Movie> movies, DateTime date)
    {
        Movies = movies;
        Date = date;
    }

    public IEnumerable<Movie> Movies { get; set; }
    public DateTime Date { get; set; }

    public void Print()
    {
        Console.WriteLine($"Movie Date: {Date}");
        Movies.ToList().ForEach(Console.WriteLine);        
    }
}