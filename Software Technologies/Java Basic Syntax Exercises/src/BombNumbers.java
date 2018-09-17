import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class BombNumbers {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        List<Integer> numbers = Arrays.stream(scanner.nextLine().split("\\s+"))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        int[] tokens = Arrays.stream(scanner.nextLine()
                .split("\\s+"))
                .mapToInt(Integer::parseInt).toArray();

        int specialNum = tokens[0];
        int range = tokens[1];

        while (numbers.contains(specialNum)) {
            int index = numbers.indexOf(specialNum);

            int leftIndex = index - range;
            if (leftIndex < 0) {
                leftIndex = 0;
            }

            int rightIndex = index + range;
            if (rightIndex >= numbers.size()) {
                rightIndex = numbers.size() - 1;
            }

            numbers.subList(leftIndex, rightIndex + 1).clear();
        }
        int sum = numbers.stream().mapToInt(Integer::intValue).sum();

        System.out.println(sum);
    }
}
