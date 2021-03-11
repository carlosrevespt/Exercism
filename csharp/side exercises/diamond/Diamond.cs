using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public static class Diamond
{
    private static List<string> leftHalfDiamond = new List<string>();
    private static int halfDiamond = 0;

    public static string Make(char target)
    {
        halfDiamond = target - 64;

        buildDiamond (target, halfDiamond);
		
		return DiamondString();
    }

    private static void buildDiamond (char target, int myHalfDiamond){
        if (myHalfDiamond > 1)
			buildDiamond ((char)(target - 1), myHalfDiamond - 1);
		
		StringBuilder diamondLine = new StringBuilder().Append(' ', halfDiamond);
		diamondLine.Replace (' ', target, halfDiamond - myHalfDiamond, 1);		
		leftHalfDiamond.Insert (myHalfDiamond - 1, diamondLine.ToString());
		
		if (myHalfDiamond != halfDiamond)
		    leftHalfDiamond.Insert (myHalfDiamond, diamondLine.ToString());
        
    }
	
	private static string DiamondString (){
		StringBuilder diamond = new StringBuilder();
		foreach (string line in leftHalfDiamond){
			diamond.Append(line);			
			string reversedLine = new string (line.Reverse().ToArray());
			diamond.Append(reversedLine.Substring(1));
			diamond.Append("\n");
		}
		
		return diamond.ToString().Substring(0, diamond.Length - 1);
	}
}