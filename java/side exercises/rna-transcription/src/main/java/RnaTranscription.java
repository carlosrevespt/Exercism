class RnaTranscription {

    String transcribe(String dnaStrand) {
        if (dnaStrand == "") {
			return "";
		}
		
		char[] nucleotides = dnaStrand.toCharArray();
		
		for (int i = 0; i < nucleotides.length; i++){
			switch (nucleotides[i]){
				case 'G':
					nucleotides[i] = 'C';
					break;
				case 'C':
					nucleotides[i] = 'G';
					break;
				case 'T':
					nucleotides[i] = 'A';
					break;
				case 'A':
					nucleotides[i] = 'U';
					break;
			}
		}
		
		return String.valueOf(nucleotides);
		
    }

}
