using System;

public static class RotationalCipher
{
    private const int UPP_A = 65;
    private const int LOW_A = 97;
    private const int TOTAL_LETTERS = 26;
      
    public static string Rotate (string text, int shiftKey){
        string cipheredText = "";
   
        foreach (char c in text) {
            if (char.IsLetter(c)) {
                int startASCII = char.IsLower(c) ? LOW_A : UPP_A;
                cipheredText += (char)(startASCII + (c + shiftKey - startASCII) % TOTAL_LETTERS);    

            } else {
                cipheredText += c;
            }
        }
        return cipheredText;
    }
}