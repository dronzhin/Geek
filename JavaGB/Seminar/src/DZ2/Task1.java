package DZ2;

import DZ2.Metods.Log;
import DZ2.Metods.MyFunction;
import DZ2.Metods.SortedArray;

import java.io.PrintStream;
import java.util.Arrays;
import java.util.logging.Logger;

//Реализуйте алгоритм сортировки пузырьком числового массива, результат после каждой итерации запишите в лог-файл.
public class Task1 {
    public static void main(String[] args) {
        int[] array = MyFunction.createRandomArray(10, 10, 10);
        System.out.println(Arrays.toString(array));
        array = SortedArray.sortedIntArray(array);
        System.out.println(Arrays.toString(array));
    }
}
