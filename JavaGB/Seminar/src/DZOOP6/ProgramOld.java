package DZOOP6;

public class ProgramOld {
    public static void main(String[] args) {
        System.out.println("Введите заказ:");
        OrderOld order = new OrderOld("", "", 0, 0);
        order.inputFromConsole();
        order.saveToJson();
    }
}
