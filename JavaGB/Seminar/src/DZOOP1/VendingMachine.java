package DZOOP1;

import java.util.Iterator;
import java.util.List;

public class VendingMachine {
    private final List<Product> products;

    public VendingMachine(List<Product> products) {
        this.products = products;
    }

    public BottleOfWater getBottleOfWater(String name, int volume) {
        Iterator var3 = this.products.iterator();

        while(var3.hasNext()) {
            Product product = (Product)var3.next();
            if (product instanceof BottleOfWater bottle) {
                if (bottle.name.equals(name) && bottle.getVolume() == volume) {
                    return bottle;
                }
            }
        }

        return null;
    }
    public BottleOfBeer getBottleOfBeer(String name, double volume) {
        Iterator var3 = this.products.iterator();

        while(var3.hasNext()) {
            Product product = (Product)var3.next();
            if (product instanceof BottleOfBeer bottle) {
                if (bottle.name.equals(name) && bottle.getVolume() == volume) {
                    return bottle;
                }
            }
        }

        return null;
    }
}

