import java.util.Scanner;
import java.util.TreeMap;

public class SumsByTown {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        TreeMap<String, Double> sumByTowns = new TreeMap<>();

        for (int i = 0; i < n; i++) {

            String[] tokens = scanner.nextLine().split("\\|");
            String town = tokens[0].trim();
            double income = Double.parseDouble(tokens[1].trim());

            if (sumByTowns.containsKey(town)) {
                sumByTowns.put(town, sumByTowns.get(town) + income);
            } else {
                sumByTowns.put(town, income);
            }
        }

        for (String town : sumByTowns.keySet()) {
            System.out.println(town + " -> " + sumByTowns.get(town));
        }
    }
}
