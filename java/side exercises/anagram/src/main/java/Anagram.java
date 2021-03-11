import java.util.Arrays;
import java.util.List; 
import java.util.ArrayList; 

class Anagram {
	
	private String word;
	private int[] wordChars;
	
	Anagram (String givenWord){
		word = givenWord.toLowerCase();
		wordChars = charsInWord(word);
	}
	
	public List<String> match (List<String> wordList){
		List<String> result = new ArrayList<String>();
		
		for (String currWord : wordList){
			if (!word.equals(currWord.toLowerCase())){
				if (isAnagram(currWord.toLowerCase())){
					result.add(currWord);
				}
			}
		}
		
		return result;
	}
	
	private boolean isAnagram (String currWord){
		return Arrays.equals(wordChars,charsInWord(currWord));
	}
	
	private int[] charsInWord (String currWord){
		int[] chars = new int[Character.MAX_VALUE];
		
		for (int i = 0; i < currWord.length(); i++){
			chars[currWord.charAt(i)]++;
		}
		
		return chars;
	}
}
