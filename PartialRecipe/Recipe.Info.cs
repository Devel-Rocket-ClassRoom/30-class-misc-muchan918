using System;

public partial class Recipe
{
    public string Name { get; }
    public int Servings { get; }
    public string[] Ingredient;
    public int IngredientNum = 0;

    public Recipe(string name, int servings, int maxNum)
    {
        Name = name;
        Servings = servings;
        Ingredient = new string[maxNum];
    }
}