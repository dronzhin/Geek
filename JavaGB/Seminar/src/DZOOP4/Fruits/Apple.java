package DZOOP4.Fruits;

import DZOOP4.Fruit;

public class Apple extends Fruit {
    public Apple(double weight) {
        super(weight);
    }

    @Override
    public void showFruit() {
        System.out.printf("Яблоко весом %.2f кг.\n", weight);
    }
}
