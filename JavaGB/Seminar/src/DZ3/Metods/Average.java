package DZ3.Metods;

import java.util.ArrayList;
import java.util.List;

public class Average {
    public static double averageNumbers(List<Integer> list){
        int sum = 0;
        if(!list.isEmpty()) {
            for (int i = 0; i < list.size(); i++) {
                sum += list.get(i);
            }
        }
        double result = (double) sum / list.size();
        return result;
    }
}
