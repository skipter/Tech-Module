import java.util.Arrays;
import java.util.Scanner;

public class Largest3Numbers {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int[] numbers = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        Arrays.sort(numbers);

        int threeLargestNumbers = Math.min(3, numbers.length);

        for (int i = 0; i < threeLargestNumbers; i++) {
            System.out.print(numbers[numbers.length - i - 1] + " ");
        }
    }
}
