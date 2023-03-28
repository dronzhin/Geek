package DZ1;

import DZ1.Metods.MyFunction;
import DZ1.Metods.TaskFunction;

import java.util.Scanner;

public class task3 {
    public static void main(String[] args) {
        int userNumber1 = MyFunction.enterInt("Введите первое число");
        String mathSym = TaskFunction.enterMathSymbol();
        int userNumber2 = MyFunction.enterInt("Введите второе число");
        System.out.println(TaskFunction.doOperation(userNumber1, userNumber2, mathSym));
    }
}
