using System;

public static class ScrabbleScore
{
    public static int Score(string input, int[] wordMultipliers = null, int[] letterIndexes = null, bool isTrippleLetter = false)
    {
        Scrabble myScrabble;

        if (wordMultipliers == null)
        {
            if (letterIndexes == null)
            {
                myScrabble = new Scrabble(input);
            }
            else
            {
                myScrabble = new Scrabble(input, letterIndexes, isTrippleLetter);
            }
        }
        else
        {
            if (letterIndexes == null)
            {
                myScrabble = new Scrabble(input, wordMultipliers);
            }
            else
            {
                myScrabble = new Scrabble(input, wordMultipliers, letterIndexes, isTrippleLetter);
            }
        }

        return myScrabble.getScore();
    }
}

public class Scrabble
{
    private readonly int[] letterScore = new int[] { 1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3, 1, 1, 3, 10, 1, 1, 1, 1, 4, 4, 8, 4, 10 };
    private const int Simple = 1;
    private const int Double = 2;
    private const int Triple = 3;
    private const int NoMultiplier = -1;
    private const int LowA = 97;
    private int score = 0;

    // Constructor for words with both letter and word multipliers.
    // int[] wordMultipliers - Array to store word multipliers (double or tripple words). It must have the word multiplier (1, 2 or 3)
    //                         in index [0] and the number of game pieces that occupie double or triple tiles on the game board in index [1].
    // int[] letterIndexes - Array to store the indexes of the letters that have letter multipliers. Assumes that the first letter in
    //                       word has index 0. If there are no double or triple letters index [0] of the array must contain -1.
    // bool isTrippleLetter - True if triple letter, false if double. If there are no double or triple letters this variable is ignored.
    // It's assumed that all inputs are valid respecting the rules above. No error checking is done (apart from null string).
    public Scrabble(string word, int[] wordMultipliers, int[] letterIndexes, bool isTrippleLetter)
    {
        if (word == null)
            throw new ArgumentException();

        if (word.Length != 0)
        {
            word = word.ToLower();
            int totalWordMultiplier = wordMultipliers[0] == Simple ? Simple
                : (int)Math.Pow(wordMultipliers[0], wordMultipliers[1]);

            int[] letterMultipliers = new int[word.Length];

            Array.Fill(letterMultipliers, Simple);

            if (letterIndexes[0] != NoMultiplier)
                for (int i = 0; i < letterIndexes.Length; i++)
                    letterMultipliers[letterIndexes[i]] = isTrippleLetter ? Triple : Double;

            for (int i = 0; i < word.Length; i++)
                score += letterScore[word[i] - LowA] * letterMultipliers[i];

            score *= totalWordMultiplier;
        }
    }

    // Constructor for words with no multipliers.
    public Scrabble(string word)
        : this(word, new int[] { Simple }, new int[] { NoMultiplier }, false)
    { }


    // Constructor for words with letters multipliers.
    public Scrabble(String word, int[] letterIndexes, bool isTrippleLetter)
        : this(word, new int[] { Simple }, letterIndexes, isTrippleLetter)
    { }

    // Constructor for words with word multipliers.
    public Scrabble(String word, int[] wordMultipliers)
        : this(word, wordMultipliers, new int[] { NoMultiplier }, false)
    { }

    public int getScore() => score;

}