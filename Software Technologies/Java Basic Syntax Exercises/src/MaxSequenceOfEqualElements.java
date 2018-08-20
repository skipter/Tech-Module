import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfEqualElements {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        //Use counter to check max sequence of equal numbers.
        int counter = 0;

        //Numbers come like strings and separate with space.
        String[] tokens = scanner.nextLine().split("\\s");

        ArrayList<Integer> numbers = new ArrayList<>();

        //Fill Int array. Parse string to Integer and add it to list.
        for (int i = 0; i < tokens.length; i++) {
            numbers.add(Integer.parseInt(tokens[i]));
        }

        int tempCounter = 0;
        //ToDo Logic check for MSEE. //ToDo temporaty list for max sequence !
        for (int i = 0; i < numbers.size(); i++) {

            if (i == i + 1) {
                counter++;
                tempCounter = counter;
            } else if (i != i + 1) {
                counter = 0;
            }
        }

    }
}
