import java.lang.Math; 

class ArmstrongNumbers {

    boolean isArmstrongNumber(int numberToCheck) {

        if (numberToCheck < 10) {
			return true;
		}
		
		int digits = numOfDigits (numberToCheck);
		int numberTemp = numberToCheck;
		int sumPowers = 0;
		
		for (int i = 0; i < digits; i++){
			sumPowers += Math.pow(numberTemp % 10, digits);
			numberTemp /= 10;
			
		}
		
		return sumPowers == numberToCheck;

    }
	
	private int numOfDigits (int number) {
		if (number < 1000000) {
			if (number < 1000) {
				if (number < 100) {
					return 2;
				} else {
					return 3;
				}
			} else {
				if (number < 10000) {
					return 4;
				} else {
					if (number < 100000) {
						return 5;
					} else {
						return 6;
					}
				}
			}
		} else {
			if (number < 100000000) {
				if (number < 10000000) {
					return 7;
				} else {
					return 8;
				}
			} else {
				if (number < 1000000000) {
					return 9;
				} else {
					return 10;
				}
			}
		}
	}

}
