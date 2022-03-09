// See https://aka.ms/new-console-template for more information

using ConsoleWithAdoNet1;

Console.WriteLine("Hello, World!");
SQLRepo repo = new SQLRepo();
List<Worker> workers = repo.GetWorkers();
var a = 12;
