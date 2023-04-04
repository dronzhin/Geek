package DZ3;

import DZ3.Metods.MyFunction;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.stream.Collectors;

//Пусть дан произвольный список целых чисел, удалить из него чётные числа
public class Task2 {

    public static void main(String[] args) {
        int[] array = MyFunction.createRandomArray(10, 0, 50);
        List<Integer> list = Arrays.stream(array).boxed().collect(Collectors.toList());
        System.out.println(list);
        for (int i = 0; i < list.size(); i++) {
            if(list.get(i) % 2 == 0){
                list.remove(i);
                i--;
            }
        }
        System.out.println(list);

    }
}
