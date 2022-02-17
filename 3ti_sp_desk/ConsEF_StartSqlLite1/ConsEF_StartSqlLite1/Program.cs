// See https://aka.ms/new-console-template for more information

using ConsEF_StartSqlLite1;
using ConsEF_StartSqlLite1.Models;

ContactRepo repo = new ContactRepo();

ContactPresenter contactPresenter = new ContactPresenter(repo);
contactPresenter.ShowAll(repo.GetAll());
Console.WriteLine("Czy dodać kontakt: (t/n)");

var isOK = Console.ReadLine();
if (!String.IsNullOrWhiteSpace(isOK)  && isOK.StartsWith("t"))  {
    Contact contact = contactPresenter.GetFromConsole();
    if(contact!=null) repo.AddNewContact(contact);
}

contactPresenter.ShowAll(repo.GetAll());

Console.WriteLine("Czy usunac kontakt o danym id: (Podaj Id lub -1 jak rezygnujesz): ");
int choice = Convert.ToInt32(Console.ReadLine());
if (choice != -1) {
    string result = repo.RemoveContact(choice)
        ? $" USUNIETO KONTAKT o Id: {choice}"
        : " NIE USUNIETO KONTAKTU ";
    Console.WriteLine(result);
}
contactPresenter.ShowAll(repo.GetAll());

Console.WriteLine("Czy wyszukac kontakty po nazwisku lub imieniu: (t/n)");

isOK = Console.ReadLine();
if (!String.IsNullOrWhiteSpace(isOK) && isOK.StartsWith("t")) {
    string query = contactPresenter.GetQuery();
    List<Contact> result = repo.GetSearch(query);
    if (result.Count > 0) {
        contactPresenter.ShowAll(result);
    }
    else {
        Console.WriteLine("Brak znalezinych kontaktow!!!");
    }
    
}

contactPresenter.ShowAll(repo.GetAll());


// CRUD dodawanie nowego kontaktu usuwanie kontaktu o id
// wyszukiwanie kontaktu po imieniu lub nazwisku
//zmiana kontaktu po wyszukaniu id