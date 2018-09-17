import java.util.Scanner;

public class IndexOfLetters {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        char[] word = scanner.nextLine().toCharArray();

        for (int i = 0; i < word.length; i++) {
            char character = word[i];
            int ascii = (int) character - 97;
            System.out.println(word[i] + " -> " + ascii);
        }
    }
}
