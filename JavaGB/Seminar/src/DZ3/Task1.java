package DZ3;

import DZ3.Metods.*;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

//Реализовать алгоритм сортировки слиянием
public class Task1 {
    public static void main(String[] args) {
        int[] myArray = MyFunction.createRandomArray(5, -30, 30);
        System.out.println(Arrays.toString(myArray));
//        int [] arrayB = {1, 2, 3};
//        int [] arrayC = {4, 5, 6};
//        System.arraycopy(arrayB, 0, arrayC, arrayB.length - 1, arrayB.length);
//        System.out.println("");
        System.out.println(Arrays.toString(SortedArray.sortIntArray(myArray)));
    }
}
