import java.util.Arrays;

class Scrabble {
	
	private static final int[] letterScore = new int[]{1,3,3,2,1,4,2,4,1,8,5,1,3,1,1,3,10,1,1,1,1,4,4,8,4,10};
	private int score = 0;
	
	// Constructor for words with both letter and word multipliers.
	// int[] wordMultipliers - Array to store word multipliers (double or tripple words). It must have the word multiplier (1, 2 or 3)
	//						   in index [0] and the number of game pieces that occupie double or triple tiles on the game board in index [1].
	// int[] letterIndexes - Array to store the indexes of the letters that have letter multipliers. Assumes that the first letter in
	//						 word has index 0. If there are no double or triple letters index [0] of the array must contain -1.
	// boolean isTrippleLetter - True if triple letter, false if double. If there are no double or triple letters this variable is ignored.
	// It's assumed that all inputs are valid respecting the rules above. No error checking is done.
	Scrabble(String word, int[] wordMultipliers, int[] letterIndexes, boolean isTrippleLetter) {		
		
		if (!word.isEmpty()){
			word = word.toLowerCase();
			int totalWordMultiplier = wordMultipliers[0] == 1 ? 1 : (int) Math.pow(wordMultipliers[0], wordMultipliers[1]);
			int[] letterMultipliers = new int[word.length()];
					
			Arrays.fill(letterMultipliers, 1);
			
			if (letterIndexes[0] != -1){
				for (int i = 0; i < letterIndexes.length; i++){
					letterMultipliers[letterIndexes[i]] = isTrippleLetter ? 3 : 2;
				}
			}
			
			for (int i = 0; i < word.length(); i++){
				score += letterScore[word.charAt(i) - 97] * letterMultipliers[i];
			}
			
			score *= totalWordMultiplier;
		}
	}
	
	// Constructor for words with no multipliers.
	Scrabble(String word) {
		this(word, new int[]{1}, new int[]{-1}, false);		
    }
	
	// Constructor for words with letters multipliers.
	Scrabble(String word, int[] letterIndexes, boolean isTrippleLetter){
		this(word, new int[]{1}, letterIndexes, isTrippleLetter);
	}
	
	// Constructor for words with word multipliers.
	Scrabble(String word, int[] wordMultipliers) {
		this(word, wordMultipliers, new int[]{-1}, false);
	}
	
	int getScore() {
        return score;
    }

    
}
