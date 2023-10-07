// using System;

// public class Fraction
// {
//     private int _top;
//     private int _bot;

//     public Fraction()
//     {
//         _top = 1;
//         _bot = 1;
//     }

//     public Fraction(int Z)
//     {
//         _top = Z;
//         _bot = 1;
//     }

//     public Fraction(int top, int bot)
//     {
//         _top = top;
//         _bot = bot;
//     }

//     public string GetFractionString()
//     {
//         string text = $"{_top}/{_bot}";
//         return text;
//     }

//     public double GetDecimalValue()
//     {
//         return (double)_top / (double)_bot;
//     }
// }

using System;
using System.Xml;

public class Chang
{
    private string _ChangsChicken;
    private string _MongoBeef;

    public void Regular()
    {
        _ChangsChicken = "Oil, White, Chang, Slurry";
        _MongoBeef = "Oil, Mongo";
    }

    public void Gluten(string _ChangsChicken, string _MongoBeef)
    {
        _ChangsChicken = "Fresh Oil, GF White, GF Chang, GF Slurry";
        _MongoBeef = "Fresh Oil, GF Mongo";
    }
    public void Allergy(string _ChangsChicken, string _MongoBeef)
    {
        _ChangsChicken = "Fresh Oil, Allergy White, Allergy Chang, Allergy Slurry";
        _MongoBeef = "Fresh Oil, Allergy Mongo";
    }
    public string GetFoodIngredients()
    {
        string food = $"{_ChangsChicken} \n {_MongoBeef}";
        return food;
    }
}