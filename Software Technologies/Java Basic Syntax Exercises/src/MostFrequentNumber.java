import java.util.Arrays;
import java.util.Scanner;

public class MostFrequentNumber {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int[] numbers = Arrays
                .stream(scanner.nextLine()
                        .split("\\s+"))
                .mapToInt(Integer::parseInt).toArray();


        int maxCounter = 0;
        int maxNnumber = numbers[0];

        for (int i = 0; i < numbers.length; i++) {
            int tempCounter = 1;
            for (int j = i; j < numbers.length; j++) {
                if (numbers[i] == numbers[j]) {
                    tempCounter++;
                }
            }

            if (tempCounter > maxCounter) {
                maxCounter = tempCounter;
                maxNnumber = numbers[i];
            }
        }
        System.out.println(maxNnumber);
    }
}
