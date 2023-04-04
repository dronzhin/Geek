package DZ3;

import DZ3.Metods.Average;
import DZ3.Metods.MyFunction;
import DZ3.Metods.SortedArray;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.stream.Collectors;

//Задан целочисленный список ArrayList. Найти минимальное, максимальное и среднее арифметическое этого списка.
public class Task3 {
    public static void main(String[] args) {
        int[] array = MyFunction.createRandomArray(10, 0, 50);
        List<Integer> list = Arrays.stream(array).boxed().collect(Collectors.toList());
        System.out.println(list);
        System.out.println(Collections.max(list));
        System.out.println(Collections.min(list));
        System.out.println(Average.averageNumbers(list));
    }
}
