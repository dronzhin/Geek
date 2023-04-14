package DZ6;

import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;

public class Main {
    public static Set<Laptop> laptops = new HashSet<>(Arrays.asList(
            new Laptop("Acer", "Red", 55000),
            new Laptop("Acer", "Red", 45000),
            new Laptop("Acer", "Black", 65000),
            new Laptop("HP", "Red", 70000),
            new Laptop("HP", "White", 65000),
            new Laptop("Asus", "White", 45000),
            new Laptop("Asus", "Black", 60000),
            new Laptop("Asus", "Black", 90000),
            new Laptop("Lenovo", "White", 45000),
            new Laptop("Lenovo", "White", 85000),
            new Laptop("Lenovo", "Black", 50000)));
    public static void main(String[] args) {
        boolean notExit = true;
        while (notExit){
            int answer = MyFunction.enterInt("База данных ноутбуков" +
                    "\n Какую операцию вы хотите провести?\n" +
                    "1 - добавить новый ноутбук\n" +
                    "2 - показать текущие ноутбуки\n" +
                    "3 - отфильтровать ноутбуки\n" +
                    "4 - выйти\n");
            if(answer == 1){
                LaptopMetods.addLaptop(laptops);
            } else if (answer == 2) {
                LaptopMetods.showLaptops(laptops);
            } else if (answer == 3) {
                LaptopMetods.filterLaptop(laptops);
            }
        }




    }

}
