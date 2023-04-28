package DZOOP4;

public abstract class Fruit{

    protected final double weight;

    public double getWeight() {
        return weight;
    }

    public Fruit(double weight) {
        this.weight = weight;
    }
    public abstract void showFruit();
}
