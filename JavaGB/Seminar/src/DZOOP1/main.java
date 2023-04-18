package DZOOP1;

import java.util.ArrayList;
import java.util.List;

public class main {
    public static void main(String[] args) {
        Product product1 = new BottleOfMilk();
        System.out.println(product1.displayInfo());
        Product product2 = new BottleOfWater();
        System.out.println(product2.displayInfo());
        Product product3 = new BottleOfBeer();
        product3.setName("Вкусное пиво");
        product3.setBrand("Моя марка");
        product3.setPrice(50);
        System.out.println(product3.displayInfo());
        List<Product> products = new ArrayList();
        products.add(product1);
        products.add(product2);
        products.add(product3);
        VendingMachine vendingMachine = new VendingMachine(products);
        BottleOfBeer bottleOfBeerRes = vendingMachine.getBottleOfBeer("Вкусное пиво", 0.5);
        if (bottleOfBeerRes != null) {
            System.out.println("Вы купили: ");
            System.out.println(bottleOfBeerRes.displayInfo());
        } else {
            System.out.println("Такой бутылки с водой нет в автомате.");
        }



    }
}
