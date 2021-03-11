class DifferenceOfSquaresCalculator {
	
	private int sumOfSquares = 0;
	private int squareOfSum = 0;

    int computeSquareOfSumTo(int input) {
        getSquareOfSum (input);
		
		return squareOfSum;
    }

    int computeSumOfSquaresTo(int input) {
        getSumOfSquares (input);
		
		return sumOfSquares;
    }

    int computeDifferenceOfSquares(int input) {
        getSquareOfSum (input);
		getSumOfSquares (input);
		
		return squareOfSum - sumOfSquares;		
    }
	
	private void getSumOfSquares (int n){
		sumOfSquares = (n * (n + 1) / 2) * (2 * n + 1) / 3;
		
	}
	
	private void getSquareOfSum (int n){
		squareOfSum = n * (n + 1) / 2;
		squareOfSum *= squareOfSum;	
	}

}
