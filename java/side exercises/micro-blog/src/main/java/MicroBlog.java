import java.lang.StringBuilder;

class MicroBlog {
    public String truncate(String input) {
        
		StringBuilder myString = new StringBuilder(input);
		int totalChars = myString.codePointCount(0, input.length());
		StringBuilder result = new StringBuilder();
		int chars = 0;
		
		if (totalChars > 5) {
			for (int i = 0; i < input.length() && chars < 5; i = input.offsetByCodePoints(i, 1)){
				chars++;
				result.appendCodePoint(myString.codePointAt(i));
			} 
		} else {
			result = myString;
		}
				
		return result.toString();
    }
}
