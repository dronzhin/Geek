package DZ2.Metods;

import DZ2.Task1;

import java.util.Arrays;
import java.util.logging.Level;
import java.util.logging.Logger;

public class SortedArray {
    private static final Logger LOG = Log.log(Task1.class.getName());
    public static int[] sortedIntArray(int[] array){
        int saveInfo = 0;
        int length = array.length;
        for (int i = 0; i < length; i++) {
            for (int j = i + 1; j < length; j++) {
                if(array[i] > array[j]){
                    saveInfo = array[i];
                    array[i] = array[j];
                    array[j] = saveInfo;
                }
            }
            LOG.log(Level.INFO, Arrays.toString(array));
        }
        return array;
    }
}
