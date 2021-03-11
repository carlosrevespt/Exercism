public class PangramChecker {

    public boolean isPangram(String input) {
        if (input.length() < 26){
			return false;
		}
		input = input.toLowerCase();
		
		boolean[] exists = new boolean[26];
		int count = 0;
		
		for (int i = 0; i < input.length(); i++){
			int currChar = input.charAt(i) - 97;
			if (currChar > -1 && currChar < 26){
				if (!exists[currChar]){
					exists[currChar] = true;
					count++;
				}
			}
		}
		
		return count == 26;
		
    }

}
