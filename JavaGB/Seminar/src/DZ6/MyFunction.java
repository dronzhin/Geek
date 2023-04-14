package DZ6;

import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.nio.file.Paths;
import java.util.Random;
import java.util.Scanner;

public class MyFunction {
    public static int enterInt(String message){
        Scanner scanner = new Scanner(System.in);
        while (true) {
            try {
                System.out.printf(message + " : ");
                return Integer.parseInt(scanner.next());
            } catch (NumberFormatException e) {
                System.out.println("Вы ввели не целое число или не число");
            }
        }
    }
    public static String enterStr(String message){
        Scanner scanner = new Scanner(System.in);
        System.out.printf(message + " : ");
        return scanner.next().trim();
    }
    public static int[] createRandomArray(int length, int min, int max){
        Random rand = new Random();
        int array[] = new int[length];
        for (int i = 0; i < length; i++) {
            array[i] = rand.nextInt(max * 2) - min;
        }
        return array;
    }
    public static String readUsingScanner(String fileName) throws IOException {
        Scanner scanner = new Scanner(Paths.get(fileName), StandardCharsets.UTF_8.name());
        String data = scanner.useDelimiter("\\A").next();
        scanner.close();
        return data;
    }
}
