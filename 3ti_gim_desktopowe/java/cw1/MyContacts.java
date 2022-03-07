import java.util.ArrayList;
import java.util.List;

public class MyContacts {
    private List<Person> contacts;
    public MyContacts() {
        contacts = new ArrayList<Person>();
    }
    public List<Person> GetContacts(){
        return contacts;
    }
    public void AddNewContact(Person p){
        contacts.add(p);
    }
}
