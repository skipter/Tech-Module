import java.util.Random;
import java.util.Scanner;

public class AdvertisementMessage {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int numberOfmessages = Integer.parseInt(scanner.nextLine());

        String[] phrases = {"Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can't live without this product."};

        String[] events = {"Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"};

        String[] author = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
        String[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
        for (int i = 0; i < numberOfmessages; i++) {


            int rndmPhrases = new Random().nextInt(phrases.length);
            int rndmEvent = new Random().nextInt(events.length);
            int rndmAuthor = new Random().nextInt(author.length);
            int rndmCities = new Random().nextInt(cities.length);

            String randomPhrases = phrases[rndmPhrases];
            String randomEvent = events[rndmEvent];
            String randomAuthor = author[rndmAuthor];
            String randomCities = cities[rndmCities];


            System.out.printf("%S %S %S %S", randomPhrases, randomEvent, randomAuthor, randomCities);
            System.out.println();
        }

    }
}
