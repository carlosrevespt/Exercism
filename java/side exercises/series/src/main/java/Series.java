import java.util.List;
import java.util.ArrayList;

class Series {
	
	private String number;
	
	Series (String number){
		this.number = number;
	}
	
	List<String> slices (int slice){
		
		if (slice < 1) {
			throw new IllegalArgumentException ("Slice size is too small.");
		}
		
		if (slice > number.length()) {
			throw new IllegalArgumentException ("Slice size is too big.");
		}
		
		List<String> result = new ArrayList<>();
		
		if (slice == number.length()) {
			result.add(number);
		} else {
			for (int i = 0; i < number.length() - slice + 1; i++){
				result.add(number.substring (i, i + slice));
			}
		}
		
		return result;
	}
}
