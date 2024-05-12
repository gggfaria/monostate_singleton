using MonostateXSingleton.Models;

namespace MonostateXSingleton.Monostate;

public class MonostateSessionNow : IMonostateSessionMovie
{
    public void SetSessionMovie(params Movie[] movies)
    {
        IMonostateSessionMovie._session.Add(new SessionMovies(movies, DateTime.Now));
    }
}