class IsogramChecker {

    boolean isIsogram(String phrase) {
        boolean[] exists = new boolean[Character.MAX_VALUE];
		phrase = phrase.toLowerCase();
		
		for (int i = 0; i < phrase.length(); i++){
			if (exists[phrase.charAt(i)] == true){
				return false;
			} else {
				if (phrase.charAt(i) != '-' && phrase.charAt(i) != ' '){
					exists[phrase.charAt(i)] = true;
				}
			}
		}
		
		return true;
    }

}
