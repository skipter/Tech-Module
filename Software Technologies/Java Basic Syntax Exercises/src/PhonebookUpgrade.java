import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class PhonebookUpgrade {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input;

        TreeMap<String, String> phonebook = new TreeMap<>();

        while (!"END".equals(input = scanner.nextLine())) {

            String[] tokens = input.split(" ");

            String command = tokens[0];

            switch (command) {
                case "A":
                    String name = tokens[1];
                    String number = tokens[2];

                    phonebook.put(name, number);
                    break;
                case "S":
                    name = tokens[1];
                    if (phonebook.containsKey(name)) {
                        String foundNumber = phonebook.get(name);
                        System.out.printf("%s -> %s%n",name, foundNumber );
                    } else {
                        System.out.printf("Contact %s does not exist. %n", name);
                    }
                    break;
                case "ListAll":
                    for (Map.Entry<String, String> entry : phonebook.entrySet()) {
                        System.out.printf("%s -> %s%n", entry.getKey(), entry.getValue());
                    }
                    break;
            }
        }
    }
}
