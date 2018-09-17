import java.util.Scanner;

public class FitStringIn20Chars {

    public static String repeatString(String str, int counter) {
        String text = "";
        for (int i = 0; i < counter; i++) {
            text += str;
        }
        return text;
    }


    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        if (input.length() < 20) {
            int astericsCounter = 20 - input.length();
            System.out.print(input);
            System.out.print(repeatString("*", astericsCounter));
        } else if (input.length() > 20) {
            System.out.println(input.substring(0, 20));
        }
    }
}
