package DZ2.Metods;

import java.util.Random;
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
    public static int[] createRandomArray(int length, int min, int max){
        Random rand = new Random();
        int array[] = new int[length];
        for (int i = 0; i < length; i++) {
            array[i] = rand.nextInt(max * 2) - min;
        }
        return array;
    }
}
