package DZOOP2.Task2;

public interface IMagicAttack extends ICreature {
    default public void magicAttack(ICreature creature, int damage) {
        if (creature.isDied()) return;
        if (isAnableDamage(damage)) {
            creature.setCurrentHealth((int)(creature.getCurrentHealth() - damage * (1 - (double)creature.getWeapon()/100)));;
            creature.setDied(true);
        } else {
            setCurrentMana(getCurrentMana() + 30);
        }
    }

    default public boolean isAnableDamage(int damage) {
        return (getCurrentMana() >= damage) ? true : false;
    }
}
