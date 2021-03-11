package allergies.exercism;

import allergies.exercism.Allergen;
import java.util.List;
import java.util.ArrayList;

class Allergies {
	
	private List<Allergen> allergenList = new ArrayList<Allergen>();
	
	Allergies (int totalScore){
		for (int i = 0; i < 8; i++){
			if ((totalScore >> i & 1) == 1) allergenList.add(Allergen.valueOf(1 << i));
		}
	}
	
	boolean isAllergicTo(Allergen myAllergen) {
		return allergenList.contains(myAllergen);
	}
	
	List<Allergen> getList(){
		return allergenList;
	}
}
