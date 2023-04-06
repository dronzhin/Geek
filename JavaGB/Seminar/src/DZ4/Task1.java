package DZ4;

import java.util.ArrayDeque;
import java.util.Deque;
import java.util.LinkedList;

//Пусть дан LinkedList с несколькими элементами. Реализуйте метод, который вернёет «перевёрнутый» список.
public class Task1 {
    public static void main(String[] args) {
        LinkedList<Integer> list = new LinkedList<>();
        list.push(5);
        list.push(15);
        list.push(52);
        list.push(56);
        list.push(25);
        System.out.println(list);
    }

}
