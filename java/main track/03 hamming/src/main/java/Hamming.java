public class Hamming {
    
	private int distance;
	
	public Hamming(String leftStrand, String rightStrand) {
        if (leftStrand.isEmpty() && !rightStrand.isEmpty()) {
			throw new IllegalArgumentException("left strand must not be empty.");
		}
		
		if (!leftStrand.isEmpty() && rightStrand.isEmpty()) {
			throw new IllegalArgumentException("right strand must not be empty.");
		}
		
		if (leftStrand.length() != rightStrand.length()) {
			throw new IllegalArgumentException("leftStrand and rightStrand must be of equal length.");
		}
		
		distance = 0;
		
		if (!leftStrand.isEmpty() && !rightStrand.isEmpty()) {
			for (int i = 0; i < leftStrand.length(); i++) {
				if (leftStrand.charAt(i) != rightStrand.charAt(i)){
					distance++;
				}
			}
		}
    }

    public int getHammingDistance() {
		
		return distance;
    }
}
