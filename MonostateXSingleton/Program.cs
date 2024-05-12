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

IMonostate monostateOne = new MonostateMovies();

monostateOne.Mono.AddParams(lotr, back);

IMonostate monostateTwo = new MonostateMovies();

monostateTwo.Mono.AddParams(avatar);

Console.WriteLine("Monostate object one");
monostateOne.Mono.ForEach(Console.WriteLine);

Console.WriteLine("Monostate object two");
monostateTwo.Mono.ForEach(Console.WriteLine);

Console.WriteLine("Monostate. is the same instance? {0}", monostateOne.Equals(monostateTwo));

#endregion