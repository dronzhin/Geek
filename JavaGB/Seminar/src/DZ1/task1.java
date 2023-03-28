package DZ1;
import Metods.*;

//Вычислить n-ое треугольного число (сумма чисел от 1 до n), n! (произведение чисел от 1 до n)
public class task1 {
    public static void main(String[] args) {
        int userNumber = MyFunction.enterInt("Введите число");
        System.out.println("Треугольное число равно - " + TaskFunction.triangularNumber(userNumber));
        System.out.println("Факториал числа равен - " + TaskFunction.factorial(userNumber));
    }
}