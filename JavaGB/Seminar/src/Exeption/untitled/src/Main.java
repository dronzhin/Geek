import java.util.InputMismatchException;
import java.util.NoSuchElementException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        // 1. Реализуйте метод, который запрашивает у пользователя ввод дробного числа (типа float), и возвращает введенное
        // значение. Ввод текста вместо числа не должно приводить к падению приложения, вместо этого, необходимо повторно
        // запросить у пользователя ввод данных.
        System.out.println(Task1.InputFlaot());

        // 2. Исправиль ошибки
        Task2.CorrectTask();

        // 3. Исправиль ошибки
        Task3.Correct();

        // 4. Разработайте программу, которая выбросит Exception, когда пользователь вводит пустую строку.
        // Пользователю должно показаться сообщение, что пустые строки вводить нельзя.
        Task4.InputMessage();

    }

}