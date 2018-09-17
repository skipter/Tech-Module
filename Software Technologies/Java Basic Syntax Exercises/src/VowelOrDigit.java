import java.util.Scanner;

public class VowelOrDigit {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        char input = scanner.next().charAt(0);
        String vowels = "aeoiu";

        if (vowels.indexOf(input) >= 0 || vowels.toUpperCase().indexOf(input) >= 0) {
            System.out.println("vowel");
        } else if (Character.isDigit(input)) {
            System.out.println("digit");
        } else {
            System.out.println("other");
        }
    }
}