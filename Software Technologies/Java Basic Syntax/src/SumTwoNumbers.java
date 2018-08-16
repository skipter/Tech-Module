import java.util.Scanner;

public class SumTwoNumbers {
    public static void main(String[] args) {


        Scanner scanner = new Scanner(System.in);

        double firstNumber = Double.parseDouble(scanner.nextLine());
        double secondNumber = Double.parseDouble(scanner.nextLine());

        double result = firstNumber + secondNumber;
        System.out.println(String.format("%.2f", result));
    }
}
