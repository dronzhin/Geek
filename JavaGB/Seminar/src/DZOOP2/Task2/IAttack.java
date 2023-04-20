package DZOOP2.Task2;

public interface IAttack extends ICreature{
    default public void attack(ICreature creature, int damage){
        if(creature.isDied()) return;
        creature.setCurrentHealth((int)(creature.getCurrentHealth() - damage * (1 - (double)creature.getWeapon()/100)));
        if(creature.getCurrentHealth() <= 0) creature.setDied(true);
    }
}
