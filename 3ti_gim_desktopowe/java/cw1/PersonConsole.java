import java.util.Scanner;
import java.util.List;

public class PersonConsole {
    public static Person GetPerson(Scanner sc){
       
        System.out.println("Podaj imie: ");
        String name = sc.next();
        System.out.println("Podaj nazwisko: ");
        String surrname = sc.next();
        
        sc.nextLine();
        System.out.println("Podaj adres: ");
        String address = sc.nextLine();        
        //sc.close();
        return new Person(name, surrname, address);
    }
    public static void ShowAllPersons(List<Person> persons){
        for (Person person : persons) {
            System.out.println(person.Info());
        }
    }
}
