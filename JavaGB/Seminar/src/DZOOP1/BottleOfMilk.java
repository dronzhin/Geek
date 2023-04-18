package DZOOP1;

public class BottleOfMilk extends Product {
    private int volume = 1;
    private int fat = 5;

    public int getVolume() {
        return this.volume;
    }

    public BottleOfMilk(String name, double price, int volume, int fat) {
        super(name, price);
        this.volume = volume;
        this.fat = fat;
    }
    public BottleOfMilk(){
        super();
    }

    public String displayInfo() {
        return "Бутылка молока\n" + super.displayInfo() + String.format("Объем: %s литр(ов)\n" +
                "Жирность: %s процент(ов)\n", this.volume, this.fat);
    }
}
