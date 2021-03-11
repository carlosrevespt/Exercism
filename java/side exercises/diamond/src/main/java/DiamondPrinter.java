import java.util.List;
import java.util.ArrayList;
import java.lang.StringBuilder;

class DiamondPrinter {
	
	private List<String> diamond = new ArrayList<>();
    private int halfDiamond;
	
    List<String> printToList(char a) {
		
		halfDiamond = a - 64;
		
		buildDiamond (a, halfDiamond);
		
		return diamond;
		
    }

	private void buildDiamond(char a, int myHalfDiamond){
		
		if (myHalfDiamond > 1) {
			buildDiamond ((char)(a - 1), myHalfDiamond - 1);
		}
		
		String diamondLine = new String(new char[halfDiamond]).replace('\0', ' ');
		StringBuilder tempLine = new StringBuilder(diamondLine);
		
		tempLine.replace (halfDiamond - myHalfDiamond, halfDiamond - myHalfDiamond + 1, String.valueOf(a));
		diamondLine = tempLine.toString();
		diamondLine += tempLine.reverse().deleteCharAt(0).toString();
		diamond.add (myHalfDiamond - 1, diamondLine);
		
		if (myHalfDiamond != halfDiamond){
		    diamond.add (myHalfDiamond, diamondLine);
		}
	}
}
