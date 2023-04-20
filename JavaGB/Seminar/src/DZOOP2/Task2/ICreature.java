package DZOOP2.Task2;

public interface ICreature {
    public String getName();
    public int getWeapon();
    public int getHealth();
    public int getCurrentHealth();
    public void setCurrentHealth(int currentHealth);
    public int getCurrentMana();
    public void setCurrentMana(int currentMana);
    public boolean isDied();
    public void setDied(boolean died);
    default public void showInfo(){
        System.out.printf("Имя: %s Здоровье: %d Броня: %d Мана: %d\n",
                getName(), getCurrentHealth(), getWeapon(), getCurrentMana());
    }
}
