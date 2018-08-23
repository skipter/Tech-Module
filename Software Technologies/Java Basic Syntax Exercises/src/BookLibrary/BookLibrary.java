package BookLibrary;

import java.util.ArrayList;
import java.util.List;

public class BookLibrary {
    private String name;
    private List<Book> books;

    public BookLibrary(String name) {
        this.name = name;
        this.books = new ArrayList<>();
    }

    public String getName() {
        return name;
    }

    public List<Book> getBooks() {
        return books;
    }
}
