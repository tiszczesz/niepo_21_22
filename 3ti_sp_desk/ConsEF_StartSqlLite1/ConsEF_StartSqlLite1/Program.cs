// See https://aka.ms/new-console-template for more information

using ConsEF_StartSqlLite1.Models;

ContactRepo repo = new ContactRepo();

List<Contact> contacts = repo.GetAll();
foreach (Contact c in contacts) {
    Console.WriteLine($"{c.FirstName} {c.LastName} Adres: {c.Address}");
}

// CRUD dodawanie nowego kontaktu usuwanie kontaktu o id
// wyszukiwanie kontaktu po imieniu lub nazwisku
//zmiana kontaktu po wyszukaniu id
