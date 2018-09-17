import java.util.Arrays;
import java.util.Scanner;

public class CensorEmailAdress {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String inputEmail = scanner.nextLine();

        String username = inputEmail.split("@")[0];
        String replacment = getReplacment(username.length(), '*', inputEmail);
        String inputText = scanner.nextLine();

        inputText = inputText.replaceAll(inputEmail, replacment);
        System.out.println(inputText);
    }

    private static String getReplacment(int length, char s, String inputEmail) {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < length; i++) {
            sb.append(s);
        }
        String username = inputEmail.split("@")[0];
        return inputEmail.replaceFirst(username, sb.toString());
    }
}
