package DZ4.Metods;

import java.util.ArrayList;
import java.util.Collections;
import java.util.LinkedList;
import java.util.List;

public class Reverse {
    public static List reverseArray(LinkedList array){
        List<Integer> newList = new ArrayList<>();
        newList.addAll(array);
        Collections.reverse(newList);
        return newList;
    }
}
