package DZOOP1;

public class BottleOfWater extends Product {
    private int volume = 1;

    public int getVolume() {
        return this.volume;
    }

    public void setVolume(int volume) {
        if(volume > 0){
            this.volume = volume;
        } else {
            this.volume = 1;
        }

    }

    public BottleOfWater(String name, double price, int volume) {
        super(name, price);
        this.volume = volume;
    }
    public BottleOfWater(){
        super();
    }
    public String displayInfo() {
        return "Бутылка воды\n" + super.displayInfo() +
                String.format("Объем: %s литр(ов)\n",this.volume);
    }
}
