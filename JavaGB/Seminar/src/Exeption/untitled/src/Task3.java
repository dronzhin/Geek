public class Task3 {
    public static void Correct(){
        try {
            int a = 90;
            int b = 3;
            System.out.println(a / b); // нет исключений, цифры известны
            printSum(23, 234); // нет исключений, простое сложение
            int[] abc = { 1, 2 };
            abc[3] = 9; // выход за пределы, обработка
        } catch (IndexOutOfBoundsException ex) {
            System.out.println("Массив выходит за пределы своего размера!");
        } catch (Exception ex) {
            System.out.println("Метиорит упал на землю и случилось чудо");
        }
    }
    public static void printSum(int a, int b){
        System.out.println(a + b);
    }
}
