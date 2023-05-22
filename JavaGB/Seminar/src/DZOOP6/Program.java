package DZOOP6;

public class Program {
    public static void main(String[] args) {
        System.out.println("Введите заказ:");

        Order order = new Order("", "", 0, 0);
        IInputInformation input = new InputToConsole();
        ISaveToFile saveJson = new SaveToJson();

        input.inputInformation(order);
        saveJson.save(order);
    }
}
