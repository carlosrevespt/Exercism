import org.junit.Before;
import org.junit.Ignore;
import org.junit.Test;

import static org.junit.Assert.assertTrue;
import static org.junit.Assert.assertFalse;
import static org.assertj.core.api.Assertions.assertThat;
import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertThrows;

public class IsbnVerifierTest {
    private IsbnVerifier isbnVerifier;

    @Before
    public void setUp() {
        isbnVerifier = new IsbnVerifier();
    }

    @Test
    public void validIsbnNumber() {
        assertTrue(isbnVerifier.isValid("3-598-21508-8"));
    }

    //@Ignore("Remove to run test")
    @Test
    public void invalidIsbnCheckDigit() {
        assertFalse(isbnVerifier.isValid("3-598-21508-9"));
    }

    //@Ignore("Remove to run test")
    @Test
    public void validIsbnNumberWithCheckDigitOfTen() {
        assertTrue(isbnVerifier.isValid("3-598-21507-X"));
    }

    //@Ignore("Remove to run test")
    @Test
    public void checkDigitIsACharacterOtherThanX() {
        assertFalse(isbnVerifier.isValid("3-598-21507-A"));
    }

    //@Ignore("Remove to run test")
    @Test
    public void invalidCharacterInIsbn() {
        assertFalse(isbnVerifier.isValid("3-598-P1581-X"));
    }

    //@Ignore("Remove to run test")
    @Test
    public void xIsOnlyValidAsACheckDigit() {
        assertFalse(isbnVerifier.isValid("3-598-2X507-9"));
    }

    //@Ignore("Remove to run test")
    @Test
    public void validIsbnWithoutSeparatingDashes() {
        assertTrue(isbnVerifier.isValid("3598215088"));
    }

    //@Ignore("Remove to run test")
    @Test
    public void isbnWithoutSeparatingDashesAndXAsCheckDigit() {
        assertTrue(isbnVerifier.isValid("359821507X"));
    }

    //@Ignore("Remove to run test")
    @Test
    public void isbnWithoutCheckDigitAndDashes() {
        assertFalse(isbnVerifier.isValid("359821507"));
    }

    //@Ignore("Remove to run test")
    @Test
    public void tooLongIsbnAndNoDashes() {
        assertFalse(isbnVerifier.isValid("3598215078X"));
    }

    //@Ignore("Remove to run test")
    @Test
    public void tooShortIsbn() {
        assertFalse(isbnVerifier.isValid("00"));
    }

    //@Ignore("Remove to run test")
    @Test
    public void isbnWithoutCheckDigit() {
        assertFalse(isbnVerifier.isValid("3-598-21507"));
    }

    //@Ignore("Remove to run test")
    @Test
    public void checkDigitOfXShouldNotBeUsedForZero() {
        assertFalse(isbnVerifier.isValid("3-598-21515-X"));
    }

    //@Ignore("Remove to run test")
    @Test
    public void emptyIsbn() {
        assertFalse(isbnVerifier.isValid(""));
    }

    //@Ignore("Remove to run test")
    @Test
    public void inputIsNineCharacters() {
        assertFalse(isbnVerifier.isValid("134456729"));
    }

    //@Ignore("Remove to run test")
    @Test
    public void invalidCharactersAreNotIgnored() {
        assertFalse(isbnVerifier.isValid("3132P34035"));
    }

    //@Ignore("Remove to run test")
    @Test
    public void inputIsTooLongButContainsAValidIsbn() {
        assertFalse(isbnVerifier.isValid("98245726788"));
    }
	
	@Test
    public void convertIsbn10Number() {
        assertEquals(isbnVerifier.convertToISBN13("3-598-21508-8"), "9783598215087");
	}
    
	@Test
    public void convertIsbn10NumberWithX() {
        assertEquals(isbnVerifier.convertToISBN13("359821507X"), "9783598215070");
	}
	
	@Test
    public void convertBadIsbn10Fails() {
        IllegalArgumentException expected =
            assertThrows(
                IllegalArgumentException.class,
                () -> isbnVerifier.convertToISBN13("3598215078X"));

        assertThat(expected)
            .hasMessage(
                "String is not a valid ISBN10 code");
    }
	
	@Test
    public void validIsbn13(){
        assertTrue(isbnVerifier.isValidIsbn13("978-3-598-21507-0"));
	}
	
	@Test
    public void invalidIsbn13(){
        assertFalse(isbnVerifier.isValidIsbn13("978-3-598-21506-0"));
	}
	
	@Test
    public void invalidIsbn13WithLetters(){
        assertFalse(isbnVerifier.isValidIsbn13("978-3-598-2150X-0"));
	}
	
	@Test
    public void invalidIsbn13WithLessThan13Digits(){
        assertFalse(isbnVerifier.isValidIsbn13("978-3-598-2150-0"));
	}
}
