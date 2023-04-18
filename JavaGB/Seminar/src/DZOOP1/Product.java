package DZOOP1;

import static java.lang.Math.round;

public class Product {
    protected String name;
    protected String brand;
    protected double price;

    public double getPrice() {
        return this.price;
    }
    public void setPrice(double price) {
        if (price <= 0.0) {
            throw new RuntimeException("Некорректная сумма товара.");
        } else {
            this.price = price;
        }
    }

    public String getName() {
        return this.name;
    }
    public void setName(String name) {
        this.name = name;
    }

    public String getBrand() {
        return this.brand;
    }
    public void setBrand(String brand) {
        this.brand = brand;
    }

    public Product() {
        this.brand = "Какой то бренд";
        this.name = "Что-то непонятное";
        this.price = 1;
    }

    public Product(String name) {
        this();
        this.name = name;
    }

    public Product(String name, double price) {
        this(name);
        this.price = price;
    }
    public Product(String brand, String name, double price){
        this(name, price);
        this.brand = brand;
    }
    public String displayInfo() {
        return String.format("Бренд: %s\n" +
                "Наименование: %s\n" +
                "Цена: %.2f рубль(ей)\n", this.brand, this.name, this.price);
    }
}

