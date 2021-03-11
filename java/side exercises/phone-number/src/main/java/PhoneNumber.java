class PhoneNumber {
	
	private static final String NOT_PUNCTUATION = "[0-9+()-. a-zA-Z]";
	private static final String NOT_LETTERS = "[^a-zA-Z]";
	private static final String NOT_NUMBERS = "[^0-9]";
	private String validNumber;
	
	PhoneNumber(String number){
		validNumber = validateNumber (number);
	}
	
	String getNumber() {
		return validNumber;
	}
	
	private String validateNumber(String number) {
		if (number.replaceAll(NOT_PUNCTUATION, "").length() > 0){
			throw new IllegalArgumentException("punctuations not permitted");
		}
		
		if (number.replaceAll(NOT_LETTERS, "").length() > 0){
			throw new IllegalArgumentException("letters not permitted");
		}
		
		number = number.replaceAll(NOT_NUMBERS, "");
		
		if (number.length() > 11) {
			throw new IllegalArgumentException("more than 11 digits");
		}
		
		if (number.length() < 10) {
			throw new IllegalArgumentException("incorrect number of digits");
		}
		
		String countryCode = "";
		
		if (number.length() == 11) {
			countryCode = number.substring(0, 1);
			number = number.substring(1);
		}
		
		if (!countryCode.equals("") && !countryCode.equals("1")){
			throw new IllegalArgumentException("11 digits must start with 1");
		}
		
		if (number.charAt(0) == '0'){
			throw new IllegalArgumentException("area code cannot start with zero");																					
		}
			
		if (number.charAt(0) == '1'){
			throw new IllegalArgumentException("area code cannot start with one");																					
		}
		
		if (number.charAt(3) == '0'){
			throw new IllegalArgumentException("exchange code cannot start with zero");																					
		}
			
		if (number.charAt(3) == '1'){
			throw new IllegalArgumentException("exchange code cannot start with one");																					
		}
		
		return number;
	}
}
