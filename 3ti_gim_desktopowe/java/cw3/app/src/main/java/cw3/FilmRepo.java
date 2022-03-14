
package cw3;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author prof
 */
public class FilmRepo {
   private List<Film> films;

    public FilmRepo(List<Film> films) {
        this.films = films;
    }

    public FilmRepo() {
        films = new ArrayList<>();
        films.add(new Film("Rambo","Jakis",220));
        films.add(new Film("Rybki","Jakis",220));
        films.add(new Film("Arizona","Jakis",150));
        films.add(new Film("Grom","Jakis",110));       
    }

    public List<Film> getFilms() {
        return films;
    }
   
}
