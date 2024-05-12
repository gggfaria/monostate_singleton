using MonostateXSingleton.Models;
using MonostateXSingleton.Singleton;

var lotr = new Movie("Lord of The Rings", "Peter Jackson");
var back = new Movie("Back to the Future", "Robert Zemeckis");
var avatar = new Movie("Avatar", "James Camaron");

#region Singleton
var listMovies = SingletonMovie.GetInstance();
var list2Moview = SingletonMovie.GetInstance();

listMovies.AddParams(lotr, back, avatar);

Console.WriteLine("List 1");
listMovies.ForEach(Console.WriteLine);
Console.WriteLine("List 2");
list2Moview.ForEach(Console.WriteLine);

Console.WriteLine(listMovies.Equals(list2Moview));
#endregion








