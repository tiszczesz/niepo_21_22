using ConsoleWithAdoNet1;

Console.WriteLine("Hello, World!");
SQLRepo repo = new SQLRepo();
List<Worker> workers = repo.GetWorkers();
ConsolePresenter.ShowWorkers(workers);
Console.Write("Czy dodac pracownika: (t-tak) ");
char answer = Console.ReadLine()[0];
if (answer == 't' || answer == 'T') {
    Worker w = ConsolePresenter.GetWorker();
    repo.AddWorker(w);
    workers = repo.GetWorkers();
    ConsolePresenter.ShowWorkers(workers);
}
Console.Write("Czy chcesz usunąć pracownika: (t-TAK)");
answer = Console.ReadLine()[0];
if (Char.ToLower(answer) == 't') {
    ConsolePresenter.ShowWorkers(workers);
    Console.Write("Podaj Id pracownika do usunięcia: ");
    int id = Convert.ToInt32(Console.ReadLine());
    repo.DeleteWorker(id);
    workers = repo.GetWorkers();
    Console.WriteLine("Po usunieciu pracownicy: ");
    ConsolePresenter.ShowWorkers(workers);
}
