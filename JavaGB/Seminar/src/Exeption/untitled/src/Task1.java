import java.util.InputMismatchException;
import java.util.NoSuchElementException;
import java.util.Scanner;

public class Task1 {
    public static float InputFlaot() {
        boolean exit = false;
        float result = 0;
        while (exit == false) {
            try {
                System.out.println("Введите дробное число:");
                Scanner scanner = new Scanner(System.in);
                result = scanner.nextFloat();
                exit = true;
            } catch (InputMismatchException e) {
                System.out.println("Неверный формат ввода, попробуйте снова");
            } catch (NoSuchElementException e) {
                System.out.println("Нет такого элемента");
            } catch (IllegalStateException e) {
                System.out.println("Не корректное состояние, попробуйте снова");
            }
        }
        return result;
    }
}
