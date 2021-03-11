class Proverb {

    private final String[] myWords;
    private final int wordCount;
    private String myProverb = "";

    Proverb(String[] words) {
        myWords = words;
        wordCount = myWords.length;
        makeProverb(0);
    }

    String recite() {
        return myProverb;
    }

    private void makeProverb (int currentWord) {
        if (currentWord == wordCount - 1){
            myProverb += String.format("And all for the want of a %s.", myWords[0]);
        } else if (wordCount > 0){
            myProverb += String.format("For want of a %s the %s was lost.\n",myWords[currentWord], myWords[currentWord + 1]);
            makeProverb(currentWord + 1);
        }
    }

}
