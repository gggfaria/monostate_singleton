using MonostateXSingleton.Models;
using MonostateXSingleton.Monostate;
using MonostateXSingleton.Singleton;

var lotr = new Movie("Lord of The Rings", "Peter Jackson");
var back = new Movie("Back to the Future", "Robert Zemeckis");
var avatar = new Movie("Avatar", "James Camaron");

#region Singleton

Console.WriteLine("-------------------Singleton-------------------");
var listMovies = SingletonMovie.GetInstance();
var list2Moview = SingletonMovie.GetInstance();

listMovies.AddParams(lotr);
list2Moview.AddParams(avatar, back);

Console.WriteLine("List 1");
listMovies.ForEach(Console.WriteLine);
Console.WriteLine("List 2");
list2Moview.ForEach(Console.WriteLine);

Console.WriteLine("Singleton. is the same instance? {0}", list2Moview.Equals(listMovies));

#endregion

#region Monostate

Console.WriteLine("-------------------Monostate-------------------");

IMonostateSessionMovie monostateSessionNow = new MonostateSessionNow();
monostateSessionNow.SetSessionMovie(lotr, back);

IMonostateSessionMovie monostateSessionNextWeek = new MonostateSessionNextWeek();

monostateSessionNextWeek.SetSessionMovie(avatar);

Console.WriteLine("Monostate Movies Today instance");
monostateSessionNow.MonoSession.ForEach(p => p.Print());

Console.WriteLine("Monostate Movies next week instance");
monostateSessionNextWeek.MonoSession.ForEach(p => p.Print());


Console.WriteLine("Monostate. is the same instance? {0}", monostateSessionNextWeek.Equals(monostateSessionNow));

#endregion