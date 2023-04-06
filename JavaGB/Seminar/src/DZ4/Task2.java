package DZ4;

import DZ4.Metods.Linked;

import java.util.LinkedList;

//        Реализуйте очередь с помощью LinkedList со следующими методами:
//        • enqueue() — помещает элемент в конец очереди,
//        • dequeue() — возвращает первый элемент из очереди и удаляет его,
//        • first() — возвращает первый элемент из очереди, не удаляя.
public class Task2 {
    public static void main(String[] args) {
        LinkedList<Integer> list = new LinkedList<>();
        Linked.enqueue(list, 5);
        Linked.enqueue(list, 15);
        Linked.enqueue(list, 25);
        Linked.enqueue(list, 35);
        System.out.println(list);
        Object firstNumber = Linked.dequeue(list);
        System.out.println(firstNumber);
        System.out.println(list);
        Object newFirstNumber = Linked.first(list);
        System.out.println(newFirstNumber);
        System.out.println(list);

    }

}
