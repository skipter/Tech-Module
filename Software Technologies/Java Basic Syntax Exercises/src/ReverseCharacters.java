import java.util.Scanner;

public class ReverseCharacters {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String word = "";
        for (int i = 0; i <= 2; i++) {

            String input = scanner.nextLine();
            word += input;

        }
        String reversedWord = new StringBuilder(word).reverse().toString();
        System.out.println(reversedWord);
    }
}
