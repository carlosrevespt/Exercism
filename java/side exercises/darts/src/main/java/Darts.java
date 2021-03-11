class Darts {
	
	private double x;
	private double y;
	
    Darts(double x, double y) {
        this.x = x;
		this.y = y;
    }

    int score() {
        double radius = getRadius (x, y);
		
		return (radius > 10 ? 0 : (radius > 5 ? 1 : (radius > 1 ? 5 : 10)));
    }
	
	private double getRadius (double x, double y) {
		return Math.sqrt(x * x + y * y);
	}

}
