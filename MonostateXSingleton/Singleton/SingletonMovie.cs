using MonostateXSingleton.Models;

namespace MonostateXSingleton.Singleton;

public static class SingletonMovie
{
    private static List<Movie>? _instance;

    public static List<Movie> GetInstance()
    {
        if (_instance is null)
            _instance = new List<Movie>();

        return _instance;
    }
}