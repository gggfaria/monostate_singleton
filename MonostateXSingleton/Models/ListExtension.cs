namespace MonostateXSingleton.Models;

public static class ListExtension
{
    public static void AddParams(this List<Movie> movies, params Movie[] moviesAdd)
    {
        movies.AddRange(moviesAdd);
    }
    
}