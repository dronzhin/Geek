package DZOOP4;

import DZOOP4.Fruits.Apple;
import DZOOP4.Fruits.Orange;

import java.util.Random;

/**
 Домашняя работа, задача:
 ========================

 a. Даны классы Fruit1, Apple extends Fruit1, Orange extends Fruit1;
 b. Класс Box, в который можно складывать фрукты. Коробки условно сортируются по типу фрукта,
 поэтому в одну коробку нельзя сложить и яблоки, и апельсины;
 c. Для хранения фруктов внутри коробки можно использовать ArrayList;
 d. Сделать метод getWeight(), который высчитывает вес коробки, зная вес одного фрукта и их количество:
 вес яблока – 1.0f, апельсина – 1.5f (единицы измерения не важны);
 e. Внутри класса Box сделать метод compare(), который позволяет сравнить текущую коробку с той, которую
 подадут в compare() в качестве параметра. true – если их массы равны, false в противоположном случае.
 Можно сравнивать коробки с яблоками и апельсинами;
 f. Написать метод, который позволяет пересыпать фрукты из текущей коробки в другую.
 Помним про сортировку фруктов: нельзя яблоки высыпать в коробку с апельсинами.
 Соответственно, в текущей коробке фруктов не остается, а в другую перекидываются объекты, которые были в первой;
 g. Не забываем про метод добавления фрукта в коробку.
 */
public class Main {
    public static void main(String[] args) {
        Random r = new Random();
        Box<Apple> boxApple = new Box<>(20);
        for (int i = 0; i < 6; i++) {
            double randomWiegth = 0.3 + (1.2 - 0.3) * r.nextDouble();
            boxApple.addFruit(new Apple(randomWiegth));
        }
        boxApple.showBox();
        System.out.println();
        Box<Orange> boxOrange = new Box<>(15);
        for (int i = 0; i < 5; i++) {
            double randomWiegth = 0.5 + (1.5 - 0.5) * r.nextDouble();
            boxOrange.addFruit(new Orange(randomWiegth));
        }
        boxOrange.showBox();
        System.out.println();
        System.out.println((boxOrange.getWieght() > boxApple.getWieght())? "Коробка апельсинов тяжелее":
                (boxOrange.getWieght() < boxApple.getWieght())? "Коробка яблок тяжелее": "Коробки равны");
        System.out.println();
        Box<Apple> newBoxApple = new Box<>(20);
        for (int i = 0; i < 3; i++) {
            double randomWiegth = 0.3 + (1.2 - 0.3) * r.nextDouble();
            newBoxApple.addFruit(new Apple(randomWiegth));
        }
        boxApple.addBox(newBoxApple);
        System.out.println();
        boxApple.showBox();
        System.out.println();
        System.out.println((boxOrange.getWieght() > boxApple.getWieght())? "Коробка апельсинов тяжелее":
                (boxOrange.getWieght() < boxApple.getWieght())? "Коробка яблок тяжелее": "Коробки равны");
    }
}
