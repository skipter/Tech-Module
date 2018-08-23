import java.util.Scanner;

public class ChangeToUppercase {
    public static void main(String[] args) {


        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        while (true) {
            int tagOpenIndex = input.indexOf("<upcase>");
            int tagCloseIndex = input.indexOf("</upcase>");

            if (tagCloseIndex < 0 || tagOpenIndex < 0) {
                break;
            }

            String replace = input.substring(tagOpenIndex, tagCloseIndex + 9);

            input = input.replace(replace, replace.substring(8, replace.length() - 9).toUpperCase());
        }

        System.out.println(input);
    }
}
