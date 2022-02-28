import java.util.Scanner;
public class Welcome {
    public static void main(String[] args){
        System.out.println("Hello from Java!!!");
        Person p1 = new Person();
        System.out.println(p1.Info());
        Scanner sc = new Scanner(System.in);
        System.out.println("Podaj imie: ");
        String name = sc.next();
        sc.close();
        System.out.println("Witaj: " + name);
    }
}
class Person{
    private String firstName;
    private String lastName;
    private String address;
    public Person(){
        this.firstName = "Adam";
        this.lastName = "Nowak";
        this.address = "Kraków ul.Bytomska 2/3";
    }
    public String Info(){
        return "Informacja o osobie "+this.firstName+" "+this.lastName+"\nadres: "+this.address;
    }
}