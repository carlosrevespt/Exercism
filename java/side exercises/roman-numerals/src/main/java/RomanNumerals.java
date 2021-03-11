import java.util.TreeMap;

class RomanNumeral {
	
	private int numberToConvert;
	private static final TreeMap<Integer, String> romanLiterals = new  TreeMap<Integer, String>();
	private String romanNumeral = "";
	
	static {
		romanLiterals.put(1000, "M");
		romanLiterals.put(900, "CM");
		romanLiterals.put(500, "D");
		romanLiterals.put(400, "CD");
		romanLiterals.put(100, "C");
		romanLiterals.put(90, "XC");
		romanLiterals.put(50, "L");
		romanLiterals.put(40, "XL");
		romanLiterals.put(10, "X");
		romanLiterals.put(9, "IX");
		romanLiterals.put(5, "V");
		romanLiterals.put(4, "IV");
		romanLiterals.put(1, "I");
	}
	
	RomanNumeral (int number) {
		numberToConvert = number;
		
		romanNumeral = convertNumber(number);
	}
	
	String getRomanNumeral() {
		return romanNumeral;
	}
	
	private String convertNumber (int number) {
		int tempNumber = romanLiterals.floorKey(number);
		
		return (tempNumber == number) ? romanLiterals.get(number) : romanLiterals.get(tempNumber) + convertNumber(number - tempNumber);
	}
}
