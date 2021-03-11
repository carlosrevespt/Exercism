class ReverseString {

    String reverse(String inputString) {
		if (inputString == ""){
			return "";
		}
		
        char[] original = inputString.toCharArray();
		char[] reversed = new char[original.length];
		
		for (int i = 0; i < original.length; i++){
			reversed[i] = original[original.length - i - 1];
		}
		
		return String.valueOf(reversed);
    }
  
}
