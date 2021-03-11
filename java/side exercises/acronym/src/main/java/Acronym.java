class Acronym {
	
	private String[] words;

    Acronym(String phrase) {
        words = phrase.split("[^a-zA-Z']");
    }

    String get() {
		String acronym = "";
        for (int i = 0; i < words.length; i++){
			if (!words[i].isEmpty()){
				acronym += words[i].trim().charAt(0);
			}
		}
		
		return acronym.toUpperCase();
    }

}
