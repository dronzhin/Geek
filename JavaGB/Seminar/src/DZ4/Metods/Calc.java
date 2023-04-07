package DZ4.Metods;

import DZ1.Metods.MyFunction;
import DZ1.Metods.TaskFunction;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Calc {
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
    public static void workCalc(){
        boolean exit = true;
        Scanner scanner = new Scanner(System.in);
        List<String> array = new ArrayList<>();
        int userNumber1 = MyFunction.enterInt("Введите первое число");
        while(exit){
            String mathSym = enterMathSymbol();
            int userNumber2 = MyFunction.enterInt("Введите второе число");
            int result = doOperation(userNumber1, userNumber2, mathSym);
            String strResult = userNumber1 + " " + mathSym + " " + userNumber2 + " = " + result;
            array.add(strResult);
            userNumber1 = result;
            for (String word: array) System.out.println(word);

            boolean flag = true;
            while (flag){
                System.out.println("Введите: \n"
                    + "= для окончания операций\n"
                    + "d для удаления прошлой операции\n"
                    + "  любой другой символ для продолжения работы с текущим результатом");
                String strExit = scanner.next();
                if (strExit.equals("=")) {
                    exit = false;
                    flag = false;
                } else if (strExit.equals("d".toLowerCase())){
                    if(array.size() > 0) {
                        array.remove(array.size() - 1);
                        for (String word : array) System.out.println(word);
                    } else {
                        System.out.println("Нет операций для удаления");
                    }
                } else {
                    flag = false;
                }
            }


        }
    }
}
