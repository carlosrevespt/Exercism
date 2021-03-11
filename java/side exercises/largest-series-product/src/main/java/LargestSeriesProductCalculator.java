import java.util.List;
import java.util.ArrayList;
import java.util.Collections;

class LargestSeriesProductCalculator {
	
	private int[] digits;
	private List<Long> sums = new ArrayList<>();
	
    LargestSeriesProductCalculator(String inputNumber) {
        char[] stringDigits = inputNumber.toCharArray();
		digits = new int[stringDigits.length];
		
		try {
			for (int i = 0; i < stringDigits.length; i++){				
				digits[i] = Integer.parseInt(String.valueOf(stringDigits[i]));				
			}
		}
		
		catch (Exception e) {
			throw new IllegalArgumentException ("String to search may only contain digits.");
		}
		
    }

    long calculateLargestProductForSeriesLength(int numberOfDigits) {
		if (numberOfDigits < 0){
			throw new IllegalArgumentException ("Series length must be non-negative.");
		}
		
		if (numberOfDigits > digits.length){
			throw new IllegalArgumentException ("Series length must be less than or equal to the length of the string to search.");
		}
		
        long partialSum;
		
		for (int i = 0; i < digits.length - numberOfDigits + 1; i++){
			partialSum = 1;
			for (int j = 0; j < numberOfDigits; j++){
				partialSum *= digits[i + j];
			} 
			sums.add(partialSum);
		}
		
		Collections.sort(sums, Collections.reverseOrder());
		
		return sums.get(0);
    }
}
