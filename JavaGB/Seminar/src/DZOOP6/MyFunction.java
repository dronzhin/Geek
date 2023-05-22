package DZOOP6;

import java.util.Scanner;

public class MyFunction {
    public static String prompt(String message) {
        Scanner in = new Scanner(System.in);
        System.out.print(message);
        return in.nextLine();
    }
}
