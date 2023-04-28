package DZOOP4;

import DZOOP4.Fruits.Apple;

import java.util.ArrayList;
import java.util.Random;

public class Box <T extends Fruit>{
    private double maxWieght;
    private double Wieght;
    private ArrayList<T> fruits = new ArrayList<>();

    public Box(double maxWieght) {
        this.maxWieght = (maxWieght <= 0) ? 1 : (maxWieght > 50) ? 50 : maxWieght;
    }
    public void addFruit(T fruit){
        if(Wieght + fruit.getWeight() <= maxWieght) {
            fruits.add(fruit);
            Wieght = Wieght + fruit.getWeight();
        } else {
            System.out.println("В это коробке нет места для данного фрукта");
        }
    }
    public void addBox(Box<T> box){
        if(Wieght + box.getWieght() <= maxWieght) {
            fruits.addAll(box.fruits);
            Wieght = Wieght + box.getWieght();
            System.out.printf("Добавили с другой коробки %d фрукта весом %.2f кг.\n", box.fruits.size(), box.Wieght);
        } else {
            System.out.println("В это коробке нет места для данного фрукта");
        }
    }

    public double getWieght() {
        return Wieght;
    }
    public void showBox(){
        for (int i = 0; i < fruits.size(); i++) {
            fruits.get(i).showFruit();
        }
        System.out.printf("Общий вес коробки - %.2f кг\n", Wieght);
    }
}
