package Metods;

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
}
