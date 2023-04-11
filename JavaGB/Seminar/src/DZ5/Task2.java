package DZ5;

import java.util.*;

import static java.util.Collections.frequency;

public class Task2 {
    public static void main(String[] args) {
        List<String> names = Arrays.asList( "Иван Иванов", "Cветлана Петрова", "Кристина Белова",
                                            "Анна Мусина", "Анна Крутова", "Иван Юрин", "Петр Лыков",
                                            "Павел Чернов", "Иван Иванов", "Петр Чернышов",
                                            "Мария Федорова", "Марина Светлова", "Мария Савина",
                                            "Иван Иванов", "Мария Рыкова", "Анна Крутова",
                                            "Марина Лугова", "Анна Владимирова", "Петр Лыков",
                                            "Иван Мечников", "Петр Петин", "Петр Лыков", "Иван Ежов");
        Map<String, Integer> nameCount = new HashMap<>();
        List<Integer> arrayCount = new ArrayList<>();
        Map<String, Integer> result = new LinkedHashMap<>();
        for (int i = 0; i < names.size(); i++) {
            int count = Collections.frequency(names, names.get(i));
            arrayCount.add(count);
            nameCount.put(names.get(i), count);
        }
        int maxCount = Collections.max(arrayCount);
        for (int i = maxCount; i > 0 ; i--) {
            for (Map.Entry<String, Integer> entry: nameCount.entrySet()) {
                if(entry.getValue().equals(i)){
                    result.put(entry.getKey(), i);
                }
            }
        }
        System.out.println(result);
    }
}
