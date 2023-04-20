package DZOOP2.Task1;

import java.util.ArrayList;

public class MainClass {
    public static Plate plate;
    public static ArrayList<Cat> cats = new ArrayList<>();
    public static void isCheckSatiety(ArrayList<Cat> cats){
        for (int i = 0; i < cats.size(); i++){
            if(!cats.get(i).isSatiety()) {
                System.out.printf("%s голодный\n", cats.get(i).getName());
            } else {
                System.out.printf("%s сытый\n", cats.get(i).getName());
            }
        }
    }
    public static void main(String[] args) {
        for (int i = 0; i < 5; i++) {
            String name = "Cat" + (i+1);
            cats.add(new Cat(name, 25));
        }
        plate = new Plate(100);
        plate.info();
        isCheckSatiety(cats);
        System.out.println();
        for (Cat cat: cats){
            cat.eat(plate);
            System.out.println("Осталось еды - " + plate.getFood());
        }
        System.out.println();
        isCheckSatiety(cats);

    }
}
