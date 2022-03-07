public class Person {
    private String firstName;
    private String lastName;
    private String address;
    public Person(){
        this.firstName = "Adam";
        this.lastName = "NOWAK";
        this.address = "Kraków ul.Bytomska 2/3";
    }
    public Person(String firstame,String lastname,String address){
        this.firstName = firstame;
        SetLastName(lastname);
        this.address = address;
    }
    public void SetLastName(String lastname){
        this.lastName = lastname.toUpperCase();
    }
    public String Info(){
        return "Informacja o osobie "+this.firstName+" "+this.lastName+"\nadres: "+this.address;
    }
}
