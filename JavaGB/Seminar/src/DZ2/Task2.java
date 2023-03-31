package DZ2;

import DZ2.Metods.MyFunction;

import java.io.IOException;
import java.util.Arrays;

public class Task2 {
    public static void main(String[] args) throws IOException {
        String text = MyFunction.readUsingScanner("src/DZ2/Metods/Text.json");
        System.out.println(text);
        String[] array = text.split("}");
        String[] newArray = new String[array.length - 1];
        for (int i = 0; i < newArray.length; i++) {
            newArray[i] = array[i].replaceAll("[\\]\\[\\}\\{\"]", "");
            newArray[i] = newArray[i].replaceAll("[:,]", " ");
        }
        for (int i = 0; i < newArray.length; i++) {
            String[] arrayWord = newArray[i].trim().split(" ");
            StringBuilder ourResult = new StringBuilder();
            ourResult.append("Студент ");
            ourResult.append(arrayWord[1]);
            ourResult.append(" получил ");
            ourResult.append(arrayWord[3]);
            ourResult.append(" по предмету ");
            ourResult.append(arrayWord[5]);
            System.out.println(ourResult.toString());
        }


    }
}
