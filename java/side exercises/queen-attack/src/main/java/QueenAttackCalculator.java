class QueenAttackCalculator {
	
	private Queen queen1;
	private Queen queen2;
	
	QueenAttackCalculator (Queen q1, Queen q2){
		
		if (q1 == null || q2 == null){
			throw new IllegalArgumentException("You must supply valid positions for both Queens.");
		}
		
		if (q1.getRow() == q2.getRow() && q1.getColumn() == q2.getColumn()){
			throw new IllegalArgumentException("Queens cannot occupy the same position.");
		}
		
		queen1 = q1;
		queen2 = q2;
	}
	
	boolean canQueensAttackOneAnother(){
				
		boolean result;
		
		if (queen1.getRow() == queen2.getRow() || queen1.getColumn() == queen2.getColumn()){
			result = true;
		} else {
			int x = Math.abs(queen1.getRow() - queen2.getRow());
			int y = Math.abs(queen1.getColumn() - queen2.getColumn());
			result = (x == y);
		}
		
		return result;
	}
}

class Queen {
	
	private final int queenRow;
	private final int queenColumn;
	
	Queen (int row, int column){
		if (row < 0){
			throw new IllegalArgumentException ("Queen position must have positive row.");
		}
		
		if (row > 7){
			throw new IllegalArgumentException ("Queen position must have row <= 7.");
		}
		
		if (column < 0){
			throw new IllegalArgumentException ("Queen position must have positive column.");
		}
		
		if (column > 7){
			throw new IllegalArgumentException ("Queen position must have column <= 7.");
		}
		
		queenRow = row;
		queenColumn = column;
	}
	
	int getRow(){
		return queenRow;
	}
	
	int getColumn(){
		return queenColumn;
	}
}



