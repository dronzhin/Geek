package DZ6;

public class Laptop {
    public String brend;
    public String color;
    public int price;
    public Laptop(String brend, String color, int price){
        this.brend = brend;
        this.color = color;
        this.price = price;
    }

    @Override
    public String toString() {
        return "Цена: " + price +  "\t\tЦвет: " + color + "\t\tБренд: " + brend;
    }
    public boolean equalsBrend(String brend){
        return true;
    }
}
