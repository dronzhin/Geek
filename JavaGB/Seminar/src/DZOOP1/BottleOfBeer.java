package DZOOP1;

public class BottleOfBeer extends Product{
    private double volume = 0.5;
    private double alcohol = 4.2;

    public double getVolume() {
        return volume;
    }

    public void setVolume(double volume) {
        if(volume > 0){this.volume = volume;}
    }

    public double getAlcohol() {
        return alcohol;
    }

    public void setAlcohol(double alcohol) {
        if(alcohol > 0) {this.alcohol = alcohol;}
    }

    public BottleOfBeer() {
        super();
    }
    public BottleOfBeer(String brand, String name, double price, double volume, double alcohol){
        super(brand, name, price);
        this.volume = volume;
        this.alcohol = alcohol;
    }

    @Override
    public String displayInfo() {
        return "Мое пиво\n" + super.displayInfo() + String.format("Объем: %.1f литр(ов)\n" +
                "Алкоголь: %.1f процент(ов)\n", this.volume, this.alcohol);
    }
}
