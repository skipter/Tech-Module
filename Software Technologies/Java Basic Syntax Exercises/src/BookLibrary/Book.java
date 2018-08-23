package BookLibrary;

public class Book {
    private String title;
    private String aithor;
    private String publisher;
    private String releaseDate;
    private String ISBN;
    private double price;


    public Book(String title, String author, String publisher, String releaseDate, String ISBN, double price) {
        this.title = title;
        this.aithor = author;
        this.publisher = publisher;
        this.releaseDate = releaseDate;
        this.ISBN = ISBN;
        this.price = price;
    }

    public String getTitle() {
        return title;
    }

    public String getAuthor() {
        return aithor;
    }

    public String getPublisher() {
        return publisher;
    }

    public String getReleaseDate() {
        return releaseDate;
    }

    public String getISBN() {
        return ISBN;
    }

    public double getPrice() {
        return price;
    }
}
