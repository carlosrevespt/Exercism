// This file was auto-generated based on version 1.1.0 of the canonical data.

using Xunit;

public class ScrabbleScoreTests
{
    [Fact]
    public void Lowercase_letter()
    {
        Assert.Equal(1, ScrabbleScore.Score("a"));
    }

    [Fact]
    public void Uppercase_letter()
    {
        Assert.Equal(1, ScrabbleScore.Score("A"));
    }

    [Fact]
    public void Valuable_letter()
    {
        Assert.Equal(4, ScrabbleScore.Score("f"));
    }

    [Fact]
    public void Short_word()
    {
        Assert.Equal(2, ScrabbleScore.Score("at"));
    }

    [Fact]
    public void Short_valuable_word()
    {
        Assert.Equal(12, ScrabbleScore.Score("zoo"));
    }

    [Fact]
    public void Medium_word()
    {
        Assert.Equal(6, ScrabbleScore.Score("street"));
    }

    [Fact]
    public void Medium_valuable_word()
    {
        Assert.Equal(22, ScrabbleScore.Score("quirky"));
    }

    [Fact]
    public void Long_mixed_case_word()
    {
        Assert.Equal(41, ScrabbleScore.Score("OxyphenButazone"));
    }

    [Fact]
    public void English_like_word()
    {
        Assert.Equal(8, ScrabbleScore.Score("pinata"));
    }

    [Fact]
    public void Empty_input()
    {
        Assert.Equal(0, ScrabbleScore.Score(""));
    }

    [Fact]
    public void Entire_alphabet_available()
    {
        Assert.Equal(87, ScrabbleScore.Score("abcdefghijklmnopqrstuvwxyz"));
    }

    [Fact]
    public void testWordWithOneDoubleLetter()
    {
        Assert.Equal(44, ScrabbleScore.Score("OxyphenButazone", letterIndexes: new int[] { 7 }));
    }

    [Fact]
    public void testWordWithTwoDoubleLetters()
    {
        Assert.Equal(54, ScrabbleScore.Score("OxyphenButazone", letterIndexes: new int[] { 7, 11 }));
    }

    [Fact]
    public void testWordWithOneTripleLetter()
    {
        Assert.Equal(47, ScrabbleScore.Score("OxyphenButazone", letterIndexes: new int[] { 7 }, isTrippleLetter: true));
    }

    [Fact]
    public void testWordWithTwoTripleLetters()
    {
        Assert.Equal(67, ScrabbleScore.Score("OxyphenButazone", letterIndexes: new int[] { 7, 11 }, isTrippleLetter: true));
    }

    [Fact]
    public void testWordWithOneDoubleWordTile()
    {
        Assert.Equal(82, ScrabbleScore.Score("OxyphenButazone", new int[] { 2, 1 }));
    }

    [Fact]
    public void testWordWithTwoDoubleWordTiles()
    {
        Assert.Equal(164, ScrabbleScore.Score("OxyphenButazone", new int[] { 2, 2 }));
    }

    [Fact]
    public void testWordWithOneTripleWordTile()
    {
        Assert.Equal(123, ScrabbleScore.Score("OxyphenButazone", new int[] { 3, 1 }));
    }

    [Fact]
    public void testWordWithTwoTripleWordTiles()
    {
        Assert.Equal(369, ScrabbleScore.Score("OxyphenButazone", new int[] { 3, 2 }));
    }

    [Fact]
    public void testWordWithDoubleLettersAndDoubleWordTiles()
    {
        Assert.Equal(88, ScrabbleScore.Score("OxyphenButazone", new int[] { 2, 1 }, new int[] { 7 }));
    }

    [Fact]
    public void testWordWithDoubleLettersAndTripleWordTiles()
    {
        Assert.Equal(132, ScrabbleScore.Score("OxyphenButazone", new int[] { 3, 1 }, new int[] { 7 }));
    }

    [Fact]
    public void testWordWithTripleLettersAndDoubleWordTiles()
    {
        Assert.Equal(94, ScrabbleScore.Score("OxyphenButazone", new int[] { 2, 1 }, new int[] { 7 }, true));
    }

    [Fact]
    public void testWordWithTripleLettersAndTripleWordTiles()
    {
        Assert.Equal(141, ScrabbleScore.Score("OxyphenButazone", new int[] { 3, 1 }, new int[] { 7 }, true));
    }
}