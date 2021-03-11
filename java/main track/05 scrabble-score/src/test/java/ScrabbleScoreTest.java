import org.junit.Ignore;
import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class ScrabbleScoreTest {

    @Test
    public void testALowerCaseLetter() {
        Scrabble scrabble = new Scrabble("a");
        assertEquals(1, scrabble.getScore());
    }

    //@Ignore("Remove to run test")
    @Test
    public void testAUpperCaseLetter() {
        Scrabble scrabble = new Scrabble("A");
        assertEquals(1, scrabble.getScore());
    }

    //@Ignore("Remove to run test")
    @Test
    public void testAValuableLetter() {
        Scrabble scrabble = new Scrabble("f");
        assertEquals(4, scrabble.getScore());
    }

    //@Ignore("Remove to run test")
    @Test
    public void testAShortWord() {
        Scrabble scrabble = new Scrabble("at");
        assertEquals(2, scrabble.getScore());
    }

    //@Ignore("Remove to run test")
    @Test
    public void testAShortValuableWord() {
        Scrabble scrabble = new Scrabble("zoo");
        assertEquals(12, scrabble.getScore());
    }

    //@Ignore("Remove to run test")
    @Test
    public void testAMediumWord() {
        Scrabble scrabble = new Scrabble("street");
        assertEquals(6, scrabble.getScore());
    }

    //@Ignore("Remove to run test")
    @Test
    public void testAMediumValuableWord() {
        Scrabble scrabble = new Scrabble("quirky");
        assertEquals(22, scrabble.getScore());
    }

    //@Ignore("Remove to run test")
    @Test
    public void testALongMixCaseWord() {
        Scrabble scrabble = new Scrabble("OxyphenButazone");
        assertEquals(41, scrabble.getScore());
    }

    //@Ignore("Remove to run test")
    @Test
    public void testAEnglishLikeWord() {
        Scrabble scrabble = new Scrabble("pinata");
        assertEquals(8, scrabble.getScore());
    }

    //@Ignore("Remove to run test")
    @Test
    public void testAnEmptyInput() {
        Scrabble scrabble = new Scrabble("");
        assertEquals(0, scrabble.getScore());
    }

    //@Ignore("Remove to run test")
    @Test
    public void testEntireAlphabetAvailable() {
        Scrabble scrabble = new Scrabble("abcdefghijklmnopqrstuvwxyz");
        assertEquals(87, scrabble.getScore());
    }
	
	@Test
    public void testWordWithOneDoubleLetter() {
        Scrabble scrabble = new Scrabble("OxyphenButazone", new int[]{7}, false);
        assertEquals(44, scrabble.getScore());
    }
	
	@Test
    public void testWordWithTwoDoubleLetters() {
        Scrabble scrabble = new Scrabble("OxyphenButazone", new int[]{7, 11}, false);
        assertEquals(54, scrabble.getScore());
    }
	
	@Test
    public void testWordWithOneTripleLetter() {
        Scrabble scrabble = new Scrabble("OxyphenButazone", new int[]{7}, true);
        assertEquals(47, scrabble.getScore());
    }
	
	@Test
    public void testWordWithTwoTripleLetters() {
        Scrabble scrabble = new Scrabble("OxyphenButazone", new int[]{7, 11}, true);
        assertEquals(67, scrabble.getScore());
    }
	
	@Test
    public void testWordWithOneDoubleWordTile() {
        Scrabble scrabble = new Scrabble("OxyphenButazone", new int[]{2, 1});
        assertEquals(82, scrabble.getScore());
    }
	
	@Test
    public void testWordWithTwoDoubleWordTiles() {
        Scrabble scrabble = new Scrabble("OxyphenButazone", new int[]{2, 2});
        assertEquals(164, scrabble.getScore());
    }
	
	@Test
    public void testWordWithOneTripleWordTile() {
        Scrabble scrabble = new Scrabble("OxyphenButazone", new int[]{3, 1});
        assertEquals(123, scrabble.getScore());
    }
	
	@Test
    public void testWordWithTwoTripleWordTiles() {
        Scrabble scrabble = new Scrabble("OxyphenButazone", new int[]{3, 2});
        assertEquals(369, scrabble.getScore());
    }
	
	@Test
    public void testWordWithDoubleLettersAndDoubleWordTiles() {
        Scrabble scrabble = new Scrabble("OxyphenButazone", new int[]{2, 1}, new int[]{7}, false);
        assertEquals(88, scrabble.getScore());
    }
	
	@Test
    public void testWordWithDoubleLettersAndTripleWordTiles() {
        Scrabble scrabble = new Scrabble("OxyphenButazone", new int[]{3, 1}, new int[]{7}, false);
        assertEquals(132, scrabble.getScore());
    }
	
	@Test
    public void testWordWithTripleLettersAndDoubleWordTiles() {
        Scrabble scrabble = new Scrabble("OxyphenButazone", new int[]{2, 1}, new int[]{7}, true);
        assertEquals(94, scrabble.getScore());
    }
	
	@Test
    public void testWordWithTripleLettersAndTripleWordTiles() {
        Scrabble scrabble = new Scrabble("OxyphenButazone", new int[]{3, 1}, new int[]{7}, true);
        assertEquals(141, scrabble.getScore());
    }

}
