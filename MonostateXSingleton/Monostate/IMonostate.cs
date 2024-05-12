using MonostateXSingleton.Models;

namespace MonostateXSingleton.Monostate;

public interface IMonostate
{
    protected static List<Movie> _movies = [];

    public List<Movie> Mono
    {
        get => _movies;
    }
   
}