using System.Linq;
using System.Collections.Generic;

public static class RomanNumeralExtension
{
    private static readonly Dictionary<int, string> romanLiterals = new Dictionary<int, string>();
    private static string romanNumber;
    private static int index;

    static RomanNumeralExtension(){
        romanLiterals.Add(1000, "M");
		romanLiterals.Add(900, "CM");
		romanLiterals.Add(500, "D");
		romanLiterals.Add(400, "CD");
		romanLiterals.Add(100, "C");
		romanLiterals.Add(90, "XC");
		romanLiterals.Add(50, "L");
		romanLiterals.Add(40, "XL");
		romanLiterals.Add(10, "X");
		romanLiterals.Add(9, "IX");
		romanLiterals.Add(5, "V");
		romanLiterals.Add(4, "IV");
		romanLiterals.Add(1, "I");
    }
    public static string ToRoman(this int value)
    {      
        index = 0;
        romanNumber = "";        
        return getValue(value);       
    }

    private static string getValue (int value){
        if (index < romanLiterals.Count) {
            int keyValue = romanLiterals.ElementAt(index).Key;
            if (value < keyValue){
                index++;
                getValue(value);
            } else {                
                if (value == keyValue){
                    romanNumber += romanLiterals.ElementAt(index).Value;
                } else {
                    romanNumber += romanLiterals.ElementAt(index).Value + getValue(value - keyValue);
                }
            }
        }

        return romanNumber;
    }
}