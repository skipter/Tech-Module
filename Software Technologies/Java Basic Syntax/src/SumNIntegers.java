import java.util.Scanner;

public class SumNIntegers {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int numberOfNumbers = Integer.parseInt(scanner.nextLine());

        int result = 0;
        int currentNumber;
        for (int i = 0; i < numberOfNumbers; i++) {
            currentNumber = Integer.parseInt(scanner.nextLine());
            result += currentNumber;
        }
        System.out.println("Sum = " + result);
    }
}
