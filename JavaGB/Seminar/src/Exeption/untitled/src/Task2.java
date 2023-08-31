public class Task2 {
    public static void CorrectTask(){
        try {
            int d = 0;
            double catchedRes1 = 8/ d;
            System.out.println("catchedRes1 = " + catchedRes1);
        } catch (ArithmeticException e) {
            System.out.println("Catching exception: " + e);
        }
        System.out.println("Есть только контролируемое исключение");
    }
}
