
package cw3;

import java.util.Collections;
import java.util.List;

/**
 *
 * @author prof
 * @literal Generyje statystyki filmów
 */
public class FilmStatistics {
    private final FilmRepo _repo;

    public FilmStatistics(FilmRepo repo) {
        this._repo = repo;
    }
    public Film getMaxLength(){
        int max = Integer.MIN_VALUE;
        Film result = null;
        for (Film film : _repo.getFilms()) {
            if(film.getLength()>max){
                result=film;
                max = film.getLength();
            }
        }
        return result;
    }
     public Film getMinLength(){
        int min = Integer.MAX_VALUE;
        Film result = null;
        for (Film film : _repo.getFilms()) {
            if(film.getLength()<min){
                result=film;
                min = film.getLength();
            }
        }
        return result;
    }
     public List<Film> OrderByTitle(){
         List<Film> result = _repo.getFilms();
         Collections.sort(result,
                 (f1,f2)->{
                     return f1.getTitle().compareTo(f2.getTitle());
                });
         return result;
     }
     public List<Film> OrderByLength(){
         List<Film> result = _repo.getFilms();
         Collections.sort(result,
                 (f1,f2)->{
                     return f1.getLength()-(f2.getLength());
                });
         return result;
     }
}
