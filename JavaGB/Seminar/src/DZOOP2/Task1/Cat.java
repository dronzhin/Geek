package DZOOP2.Task1;

public class Cat {
    private String name;
    private int appetite;
    private boolean satiety = false;
    public Cat(String name, int appetite) {
        this.name = name;
        this.appetite = appetite;
    }

    public boolean isSatiety() {
        return satiety;
    }

    public void eat(Plate plate) {
        if(appetite > plate.getFood()) {
            plate.setFood(plate.getFood() + appetite);
            System.out.printf("Добавили %s еды", appetite);
        }
        if(appetite > plate.getFood()) { // unnecessary condition
            System.out.println("Еды в тарелке не достаточно");
        } else {
            plate.setFood(plate.getFood() - appetite);
            plate.isEnoughFood();
            satiety = true;
            System.out.printf("%s съел %d еды\n", name, appetite);
        }
    }

    public int getAppetite() {
        return appetite;
    }

    public String getName() {
        return name;
    }
}