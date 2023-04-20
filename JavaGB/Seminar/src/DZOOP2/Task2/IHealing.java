package DZOOP2.Task2;

public interface IHealing extends ICreature{
    default public void healing(ICreature creator, int health) {
        if(isDied()) return;
        if(isAnableHealing(health)) {
            if (creator.getCurrentHealth() + health < creator.getHealth()) {
                creator.setCurrentHealth(creator.getCurrentHealth() + health);
            } else {
                creator.setCurrentHealth(creator.getHealth());
            }
            setCurrentMana(getCurrentMana() - health);
        } else {
            setCurrentMana(getCurrentMana() + 30);
        }
    }
    default public boolean isAnableHealing(int health){
        return  (getCurrentMana() >= health) ? true : false;
    }
}
