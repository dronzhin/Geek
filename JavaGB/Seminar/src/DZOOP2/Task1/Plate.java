package DZOOP2.Task1;

public class Plate {
    private int food;
    public Plate(int food) {
        this.food = food;
    }
    public void info() {
        System.out.println("plate: " + food);
    }

    public void setFood(int food) {
            this.food = food;
    }
    public void isEnoughFood(){
        if(food < 50){
            food += 50;
            System.out.println("Добавили 50 еды в тарелку");
        }
    }

    public int getFood() {
        return food;
    }
}