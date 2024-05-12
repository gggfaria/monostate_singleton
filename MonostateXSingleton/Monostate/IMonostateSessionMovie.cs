using MonostateXSingleton.Models;

namespace MonostateXSingleton.Monostate;

public interface IMonostateSessionMovie
{
    protected static List<SessionMovies> _session = [];

    public  List<SessionMovies> MonoSession
    {
        get => _session;
    }

    void SetSessionMovie(params Movie[] movies);
    
}