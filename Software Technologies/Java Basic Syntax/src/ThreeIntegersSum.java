import java.util.Scanner;

public class ThreeIntegersSum {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        String[] split = (input.split(" "));

        int[] numbers = new int[split.length];

        for (int i = 0; i < split.length; i++) {
            numbers[i] = Integer.parseInt(split[i]);
        }

        //ToDo logic operations.

    }
}
