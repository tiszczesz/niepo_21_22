import java.util.Scanner;
public class Welcome {
    public static void main(String[] args){
        System.out.println("Hello from Java!!!");
        MyContacts contacts = new MyContacts();
        Scanner sc = new Scanner(System.in);
        System.out.print("Ile kontaktów dodać: ");
        int size = sc.nextInt();
        for(int i=0;i<size;i++){
            Person p = PersonConsole.GetPerson(sc);
            contacts.AddNewContact(p);
        }
        PersonConsole.ShowAllPersons(contacts.GetContacts());
        sc.close();
    }
}
