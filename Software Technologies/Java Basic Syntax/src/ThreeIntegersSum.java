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

        int firstNum = numbers[0];
        int secondNum = numbers[1];
        int thirdNum = numbers[2];

        //ToDo Print the elements, in such way, that num1 <= num2.

        if (firstNum + secondNum == thirdNum) {
            System.out.println(firstNum + " + " +secondNum + " = " + thirdNum);
        } else if (secondNum + thirdNum == firstNum) {
            System.out.println(secondNum + " + " +thirdNum + " = " + firstNum);
        } else if (firstNum + thirdNum == secondNum) {
            System.out.println(firstNum + " + " +thirdNum + " = " + secondNum);
        } else {
            System.out.println("No");
        }
    }
}
