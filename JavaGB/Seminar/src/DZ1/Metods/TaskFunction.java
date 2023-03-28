package DZ1.Metods;

import java.util.Scanner;
import static java.lang.Math.sqrt;

public class TaskFunction {
    public static int triangularNumber(int number){
        return number * (number +1) / 2;
    }
    public static int factorial(int number){
        int result = 1;
        for (int i = 2; i <= number ; i++) {
            result *= i;
        }
        return result;
    }
    public static boolean prime(int number){
        for(int i=2;i<=sqrt(number);i++)
        if(number % i == 0)
            return false;
        return true;
    }
    public static String primeNumbers(int number){
        String result = "";
        for (int i = 2; i <= number; i++) {
            if (prime(i)){
                result = result + Integer.toString(i) + " ";
            }
        }
        return result;
    }
    public static String enterMathSymbol(){
        String enter = "";
        Scanner scanner = new Scanner(System.in);
        boolean flag = true;
        while (true) {
            System.out.println("Введите +, -, /, * :");
            enter = scanner.next();
            if ("+-/*".contains(enter) && enter.length() == 1) {
                break;
            } else {
                System.out.println("Вы ввели не правильный символ");
            }
        }
        return enter;
    }
    public static int doOperation(int number1, int number2, String symb){
        int result = 0;
        if (symb.equals("+")){
            result = number1 + number2;
        } else if (symb.equals("-")) {
            result = number1 - number2;
        } else if (symb.equals("/")) {
            result = number1 / number2;
        }
        else if (symb.equals("*")) {
            result = number1 * number2;
        }
        return result;
    }
}
