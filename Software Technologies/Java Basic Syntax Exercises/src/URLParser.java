import java.util.Scanner;

public class URLParser {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        String protocol = "";
        String server = "";
        String resource = "";

        int protocolEndIndex = input.indexOf("://");
        if (protocolEndIndex > 0) {
            protocol = input.substring(0, input.indexOf("://"));
            input = input.substring(protocolEndIndex + 3);
        }

        int serverEndIndex = input.indexOf('/');
        if (serverEndIndex < 0) {
            server = input;
        }
        else {
            server = input.substring(0, serverEndIndex);
            resource = input.substring(serverEndIndex + 1);
        }

        System.out.printf("[protocol] = \"%s\"", protocol);
        System.out.println();
        System.out.printf("[server] = \"%s\"", server);
        System.out.println();
        System.out.printf("[resource] = \"%s\"", resource);

    }
}
