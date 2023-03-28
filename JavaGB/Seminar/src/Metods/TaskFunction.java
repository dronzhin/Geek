package Metods;

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
}
