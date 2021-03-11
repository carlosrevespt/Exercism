import java.util.Map;
import java.util.HashMap;
import java.util.stream.IntStream;

class NucleotideCounter {
	
	private Map<Character, Integer> nucleotides = new HashMap<Character, Integer>();
	private String dnaStrand;
	private int total = 0;
	
	
	NucleotideCounter (String dna) {
		dnaStrand = dna;
		nucleotides.put ('A', 0);
		nucleotides.put ('C', 0);
		nucleotides.put ('G', 0);
		nucleotides.put ('T', 0);
		
		if (!dna.isEmpty()) {
			nucleotides.put ('A', getCount('A'));
			nucleotides.put ('C', getCount('C'));
			nucleotides.put ('G', getCount('G'));
			nucleotides.put ('T', getCount('T'));
		}
		
		if (total != dna.length()){
			throw new IllegalArgumentException();
		}
		
	}
	
	Map<Character, Integer> nucleotideCounts(){
		return nucleotides;
	}
	
	private int getCount (char nucleotide) {
		int count = (int) IntStream.range(0, dnaStrand.length())
								   .filter(i -> dnaStrand.charAt(i) == nucleotide)
								   .count();
		total += count;
		return count;
	}
}
