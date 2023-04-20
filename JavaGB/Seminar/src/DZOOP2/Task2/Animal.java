package DZOOP2.Task2;

public class Animal implements IHealer, IPaladin, IWarrior, IPriest {
    protected String name;
    protected int health;
    protected int currentHealth;
    protected int weapon;
    protected int mana;
    protected int currentMana;
    protected boolean isDied;

    public Animal() {
        this.name = "Существо";
        this.health = 100;
        this.weapon = 10;
        this.currentHealth = this.health;
        this.currentMana = this.mana;
    }

    public Animal(String name, int health, int weapon, int mana) {
        this.name = name;
        this.health = health;
        this.weapon = weapon;
        this.currentHealth = this.health;
        this.mana = mana;
        this.currentMana = this.mana;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Override
    public int getHealth() {
        return health;
    }

    public void setHealth(int health) {
        this.health = health;
    }

    @Override
    public int getCurrentHealth() {
        return currentHealth;
    }

    @Override
    public void setCurrentHealth(int currentHealth) {
        this.currentHealth = currentHealth;
    }

    public int getWeapon() {
        return weapon;
    }

    public void setWeapon(int weapon) {
        this.weapon = weapon;
    }

    public int getMana() {
        return mana;
    }

    public void setMana(int mana) {
        this.mana = mana;
    }

    public int getCurrentMana() {
        return currentMana;
    }

    public void setCurrentMana(int currentMana) {
        this.currentMana = currentMana;
    }

    public boolean isDied() {
        return isDied;
    }

    public void setDied(boolean died) {
        isDied = died;
    }
}
