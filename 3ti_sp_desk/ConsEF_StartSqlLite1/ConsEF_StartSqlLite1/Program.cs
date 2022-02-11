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







// CRUD dodawanie nowego kontaktu usuwanie kontaktu o id
// wyszukiwanie kontaktu po imieniu lub nazwisku
//zmiana kontaktu po wyszukaniu id