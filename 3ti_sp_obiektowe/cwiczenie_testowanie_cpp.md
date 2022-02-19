# Testowanie aplikacji konsolowych w C++ (Unit Tests) MS TESTS
1. Napisać i przetestować aplikację:
   1. Obliczjącą ilość znaków w string lub vector<string>
   2. Obliczjącą ilość liter w string lub vector<string>
   3. Obliczjącą ilość cyfr w string lub vector<string>
   4. Obliczjącą ilość samogłosek w string lub vector<string>
   5. Obliczjącą ilość wyrazów o zadanej długości lub conajmniej o tej długości w string lub vector<string>
   6. Trudniejsze wyciąganie z html tagów np &lt;p&gt;
   7. Wykonanie testów dla tych funkcjonalności

```cpp
class TextInfo{
    private:
     std::vector<std::string> text;
     public:
     TextInfo(std::vector<std::string> text){
         this->text = text;
     }
     // przykładowe metody
     int GetChars(){
         ....
     }
     int GetLetter(){
         ....
     }
     int GetNumeric(){
         ...
     }
     ....
};

```