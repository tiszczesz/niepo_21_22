package cw3;

/**
 *
 * @author prof
 */
public class Film {

    private String title;
    private String director;
    private int length;

    public Film() {
        title = "Noname";
        director = "No name";
        length = 200;
    }
   /**    
    * @param title String
    * @param director String
    * @param length int
    */
    public Film(String title, String director, int length) {
        this.title = title;
        this.director = director;
        this.length = length;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getDirector() {
        return director;
    }

    public void setDirector(String director) {
        this.director = director;
    }

    public int getLength() {
        return length;
    }

    public void setLength(int length) {
        this.length = length;
    }

    @Override
    public String toString() {
        return "Film{" + "Tytul = " + title + ", Rezyser = " + director + ", dlugosc filmu = " + length + '}';
    }
    
}
