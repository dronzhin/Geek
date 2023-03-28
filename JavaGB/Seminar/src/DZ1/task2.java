package DZ1;
import Metods.*;
//Вывести все простые числа от 1 до 1000
public class task2 {
    public static void main(String[] args) {
        int userNumber = MyFunction.enterInt("Введите число");
        System.out.println(TaskFunction.primeNumbers(userNumber));
    }
}
