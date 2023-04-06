package DZ4;

import DZ4.Metods.Reverse;

import java.util.*;

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
        System.out.println(Reverse.reverseArray(list));
    }

}
