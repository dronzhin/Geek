package Metods;

import java.util.Scanner;

public class MyFunction {
    public static int enterInt(String message){
        Scanner scanner = new Scanner(System.in);
        while (true) {
            try {
                System.out.println(message + " :");
                return Integer.parseInt(scanner.next());
            } catch (NumberFormatException e) {
                System.out.println("Вы ввели не целое число или не число");
            }
        }
    }
}
