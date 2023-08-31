import java.util.InputMismatchException;
import java.util.NoSuchElementException;
import java.util.Scanner;

public class Task4 {
    public static String InputMessage() {
        System.out.println("Введите сообщение");
        Scanner scanner = new Scanner(System.in);
        String result = scanner.nextLine();
        if(result == ""){
            throw new RuntimeException("Пользователь ввел пустую строку");
        }
        return result;
    }
}
