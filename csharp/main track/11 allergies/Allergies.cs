using System;
using System.Collections.Generic;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    private List<Allergen> allergenList = new List<Allergen>();

    public Allergies(int mask)
    {
        foreach (Allergen i in Enum.GetValues(typeof(Allergen))){
            if ((mask >> (int)i & 1) == 1) allergenList.Add(i);
        }
    }

    public bool IsAllergicTo(Allergen allergen) => allergenList.Contains(allergen);

    public Allergen[] List() => allergenList.ToArray();
}