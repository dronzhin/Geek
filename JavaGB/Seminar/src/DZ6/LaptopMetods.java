package DZ6;

import java.util.HashSet;
import java.util.Map;
import java.util.Set;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class LaptopMetods {
    public static void addLaptop(Set<Laptop> laptops){
       String brend = MyFunction.enterStr("Введите название ноутбука");
       String color = MyFunction.enterStr("Введите цвет ноутбука");
       int price = MyFunction.enterInt("Введите стоимость ноутбука");
       laptops.add(new Laptop(brend, color, price));
    }
    public static void showLaptops(Set<Laptop> laptops){
        System.out.println("База данных ноубуков:");
        if(laptops.size() == 0){
            System.out.println("В базе нет ноутбуков");
        } else {
            for (Laptop laptop : laptops) {
                System.out.println(laptop.toString());
            }
        }
        System.out.println();
    }
    public static void filterLaptop(Set<Laptop> laptops){
        int answerChoice = MyFunction.enterInt("Вы хотите отфильстровать по бренду или по цвету?\n" +
                "1 - бренд\n" +
                "2 - цвет\n");
        Set<Laptop> filterLaptops = new HashSet<>();
        System.out.println(answerChoice);
        if(answerChoice == 1){
            int answerBrend = MyFunction.enterInt("Выерите бренд\n" +
                    "1 - Asus\n" +
                    "2 - Acer\n" +
                    "3 - Lenovo\n" +
                    "4 - HP\n");
            if(answerBrend == 1){
                filterLaptops = laptops.stream().filter(x -> x.brend == "Asus").collect(Collectors.toSet());
            } else if(answerBrend == 2){
                filterLaptops = laptops.stream().filter(x -> x.brend == "Acer").collect(Collectors.toSet());
            } else if(answerBrend == 3){
                filterLaptops = laptops.stream().filter(x -> x.brend == "Lenovo").collect(Collectors.toSet());
            } else if(answerBrend == 4){
                filterLaptops = laptops.stream().filter(x -> x.brend == "HP").collect(Collectors.toSet());
            } else {
                System.out.println("Команда введена не правильно");
            }
        } else if(answerChoice == 2) {
            int answerColor = MyFunction.enterInt("Выерите цвет\n" +
                    "1 - Red\n" +
                    "2 - Black\n" +
                    "3 - White\n");
            if (answerColor == 1) {
                filterLaptops = laptops.stream().filter(x -> x.color == "Red").collect(Collectors.toSet());
            } else if (answerColor == 2) {
                filterLaptops = laptops.stream().filter(x -> x.color == "Black").collect(Collectors.toSet());
            } else if (answerColor == 3) {
                filterLaptops = laptops.stream().filter(x -> x.color == "White").collect(Collectors.toSet());
            } else {
                System.out.println("Команда введена не правильно");
            }

        }
        showLaptops(filterLaptops);
    }
}
