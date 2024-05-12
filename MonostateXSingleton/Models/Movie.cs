namespace MonostateXSingleton.Models;

public class Movie
{
    public Movie(string name, string director)
    {
        Name = name;
        Director = director;
    }

    public string Name { get; set; }
    public string Director { get; set; }

    public override string ToString()
    {
        return $"Movie: {Name} Director: {Director}";
    }
}