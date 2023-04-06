package DZ4.Metods;

import java.util.LinkedList;

public class Linked {
    public static LinkedList enqueue(LinkedList list, int number){
        list.addLast(number);
        return list;
    }
    public static Object dequeue(LinkedList list){
        return list.pop();
    }
    public static Object first(LinkedList list){
        return list.getFirst();
    }
}
