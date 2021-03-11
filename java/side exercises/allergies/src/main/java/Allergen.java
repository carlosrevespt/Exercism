package allergies.exercism;

import java.util.Map;
import java.util.HashMap;

enum Allergen {
    EGGS(1),
    PEANUTS(2),
    SHELLFISH(4),
    STRAWBERRIES(8),
    TOMATOES(16),
    CHOCOLATE(32),
    POLLEN(64),
    CATS(128);

    private final int score;

    Allergen(int score) {
        this.score = score;
    }

    int getScore() {
        return score;
    }
	
	private static Map<Integer, Allergen> map = new HashMap<Integer, Allergen>();

    static {
        for (Allergen allergenEnum : Allergen.values()) {
            map.put(allergenEnum.score, allergenEnum);
        }
    }
	
	static Allergen valueOf(int score) {
        return map.get(score);
    }
}
