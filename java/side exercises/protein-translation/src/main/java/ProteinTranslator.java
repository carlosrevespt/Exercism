import java.util.List;
import java.util.ArrayList;
import java.util.Map;
import java.util.HashMap;

class ProteinTranslator {
	
	private Map<String, String> proteins = new HashMap<>();
	
	public ProteinTranslator () {
		proteins.put ("AUG", "Methionine");		
		proteins.put ("UUU", "Phenylalanine");
		proteins.put ("UUC", "Phenylalanine");
		proteins.put ("UUA", "Leucine");
		proteins.put ("UUG", "Leucine");
		proteins.put ("UCU", "Serine");
		proteins.put ("UCC", "Serine");
		proteins.put ("UCA", "Serine");
		proteins.put ("UCG", "Serine");
		proteins.put ("UAU", "Tyrosine");
		proteins.put ("UAC", "Tyrosine");
		proteins.put ("UGU", "Cysteine");
		proteins.put ("UGC", "Cysteine");
		proteins.put ("UGG", "Tryptophan");
		proteins.put ("UAA", "STOP");
		proteins.put ("UAG", "STOP");
		proteins.put ("UGA", "STOP");
	}

    List<String> translate(String rnaSequence) {
        List<String> translation = new ArrayList<>();
		int i = 0;
		
		while (i < rnaSequence.length() && proteins.get(rnaSequence.substring(i,i + 3)) != "STOP"){	
			translation.add (proteins.get(rnaSequence.substring(i,i + 3)));
			i += 3;
		}
		
		return translation;
    }
}
