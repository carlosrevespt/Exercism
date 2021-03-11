
import java.util.Arrays;
import java.util.stream.*;

class PigLatinTranslator {
	
	private String[] phraseArray;
	private String wordToTransl;
	private int firstVowel;
	
	public String translate (String phrase) {
		setPhrase (phrase);
		String[] translatedPhrase = new String[phraseArray.length];
		for (int i = 0; i < phraseArray.length; i++) {
			setWord (phraseArray[i]);
			translatedPhrase[i] = translateWord();
		}
		
		return Arrays.stream(translatedPhrase).collect(Collectors.joining(" "));
	}
	
	private void setPhrase(String phrase) {
		phraseArray = phrase.split(" ");
	}
	
	private void setWord (String word){
		wordToTransl = word;
		int index = 0;
		
		while (index != -1 && !isVowel(wordToTransl.charAt(index))){
			index++;
			if (index == wordToTransl.length()){
				index = -1;
			}
		}
		
		firstVowel = index;
	}
	
	private String translateWord (){
		String translation = "";
		
		if (firstVowel == 0) {
			translation = wordToTransl + "ay";
			
		} else {
			if (wordToTransl.substring(0,2).equals("xr") || wordToTransl.substring(0,2).equals("yt")) {
				translation = wordToTransl + "ay";
			} else {
				if (wordToTransl.substring(0,2).equals("qu")) {
					firstVowel++;
				}
				
				if (firstVowel == 2 && wordToTransl.substring(1,3).equals("qu")) {
					firstVowel++;
				}
				
				if (firstVowel == -1) {
					do {
						firstVowel++;
					} while (wordToTransl.charAt(firstVowel) != 'y');
				}
				
				translation = wordToTransl.substring(firstVowel) + wordToTransl.substring(0,firstVowel) + "ay";
			}
		}
		
		return translation;
	}
	
	private boolean isVowel (char letter){
		return (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u');
	}
}
