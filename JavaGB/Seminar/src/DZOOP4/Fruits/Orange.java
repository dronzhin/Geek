package DZOOP4.Fruits;

import DZOOP4.Fruit;

public class Orange extends Fruit {
    public Orange(double weight) {
        super(weight);
    }
    @Override
    public void showFruit() {
        System.out.printf("Апельсин весом %.1f кг.\n", weight);
    }
}
