import java.util.concurrent.ThreadLocalRandom;
import java.util.Arrays;

class DnDCharacter {
	
	private int strength;
	private int dexterity;
	private int constitution;
	private int intelligence;
	private int wisdom;
	private int charisma;
	private int hitpoints;
	
	DnDCharacter () {
		strength = ability();
		dexterity = ability();
		constitution = ability();
		intelligence = ability();
		wisdom = ability();
		charisma = ability();
		hitpoints = 10 + modifier(constitution);
	}	

    int ability() {
        int[] diceThrows = new int[4];
		
		for (int i = 0; i < 4; i++){
			diceThrows[i] = ThreadLocalRandom.current().nextInt(1, 7);
		}
		
		Arrays.sort(diceThrows);
		
		return diceThrows[1] + diceThrows[2] + diceThrows[3];
		
    }

    int modifier(int input) {
		
        return (int) (Math.floor(((double) input - 10) / 2));
    }

    int getStrength() {
        return strength;
    }

    int getDexterity() {
        return dexterity;
    }

    int getConstitution() {
        return constitution;
    }

    int getIntelligence() {
        return intelligence;
    }

    int getWisdom() {
        return wisdom;
    }

    int getCharisma() {
        return charisma;
    }

    int getHitpoints() {
        return hitpoints;
    }

}
