class PigLatinTranslator {
	
	public String translate (String word) {
		String translation = "";
		switch (word.charAt(0)){
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u':
				translation += word + "ay";
				break;
			case 'x':
				if (word.charAt(1) == 'r'){
					translation += word + "ay";
				} else {
					translation = compose (word);
				}
				break;
			case 'y':
				if (word.charAt(1) == 't'){
					translation += word + "ay";
				} else {
					translation = word.substring (1) + "yay";
				}
				break;
			case 's':
				if (word.substring(1,3) == "qu"){
					translation = word.substring (3) + "squay";
				} else {
					translation = compose (word);
				}
				break;
			default:
				translation = compose (word);
				break;
			
		}
		return translation;
	}
	
	private String compose (String word){
		int index = 0;
		
		while (isConsonant(word.charAt(index))){
			index++;
		}
		
		return word.substring(index) + word.substring(0, index) + "ay";
	}
	
	private boolean isConsonant (char letter){
		return !(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'y');
		
	}
}
