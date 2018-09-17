import java.util.Scanner;

public class CompareCharArray {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String firstArr = scanner.nextLine();
        String secondArr = scanner.nextLine();

        char[] arr1 = firstArr.replaceAll(" ", "").toCharArray();
        char[] arr2 = secondArr.replaceAll(" ", "").toCharArray();
        String convertArray1 = String.valueOf(arr1);
        String convertArray2 = String.valueOf(arr2);

        int min = Math.min(arr1.length, arr2.length);

        Boolean isFirst = false;
        for (int i = 0; i < min; i++) {

            int index1 = (int)arr1[i];
            int index2 = (int)arr2[i];

            if (index1 <= index2) {
                isFirst = true;
            } else {
                break;
            }
        }
        if (isFirst == true && min == arr1.length) {
            System.out.println(convertArray1);
            System.out.println(convertArray2);
        } else {
            System.out.println(convertArray2);
            System.out.println(convertArray1);
        }
    }
}
