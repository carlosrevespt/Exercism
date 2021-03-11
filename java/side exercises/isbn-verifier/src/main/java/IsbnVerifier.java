class IsbnVerifier {

    boolean isValid(String stringToVerify) {
        return validateISBN(stringToVerify);
    }
	
	boolean isValidIsbn13(String stringToVerify) {
        return validateISBN13(stringToVerify);
    }
	
	private boolean validateISBN(String stringToVerify){
		boolean validation = true;
		stringToVerify = stringToVerify.replaceAll("[^0-9X]", "");
		
		if (stringToVerify.length() != 10){
			validation = false;
		} else if ((stringToVerify.replaceAll("[0-9]", "").length() == 1 && stringToVerify.charAt(9) != 'X') ||
				   (stringToVerify.replaceAll("[0-9]", "").length() > 1)) {
			validation = false;
		} else {
			int product = 0;
			for (int i = 0; i < 9; i++){
				product += Integer.parseInt(String.valueOf(stringToVerify.charAt(i))) * (10 - i);
			}
			
			product += stringToVerify.charAt(9) == 'X' ? 10 : Integer.parseInt(String.valueOf(stringToVerify.charAt(9)));
			
			validation = product % 11 == 0;
		}
		
		return validation;
		
	}
	
	String convertToISBN13 (String isbn10){
		if (!validateISBN(isbn10)){
			throw new IllegalArgumentException("String is not a valid ISBN10 code");
		}
		
		isbn10 = isbn10.replaceAll("[^0-9]", "");
		
		String isbn13 = "978" + (isbn10.length() == 10 ? isbn10.substring(0, 9) : isbn10);
		int checkDigit = 0;
		
		for (int i = 0; i < 12; i++){
			int digit = Integer.parseInt(String.valueOf(isbn13.charAt(i)));
			checkDigit += digit * (i % 2 == 0 ? 1 : 3);
		}
		
		checkDigit = 10 - (checkDigit % 10);
		
		isbn13 += checkDigit == 10 ? 0 : checkDigit;
		
		return isbn13;
		
	}
	
	private boolean validateISBN13(String stringToVerify){
		boolean validation = true;
		stringToVerify = stringToVerify.replaceAll("[^0-9]", "");
		
		if (stringToVerify.length() != 13){
			validation = false;
		} else {
			int checkDigit = 0;
			for (int i = 0; i < 12; i++){
				int digit = Integer.parseInt(String.valueOf(stringToVerify.charAt(i)));
				checkDigit += digit * (i % 2 == 0 ? 1 : 3);
			}
			
			checkDigit = 10 - (checkDigit % 10);
			
			validation = (checkDigit == 10 ? 0 : checkDigit) == Integer.parseInt(String.valueOf(stringToVerify.charAt(12)));
		}
		
		return validation;
		
	}

}
