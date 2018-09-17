import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class Phonebook {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String input;
        LinkedHashMap<String, String> phonebook = new LinkedHashMap<>();

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
            }
        }
    }
}
