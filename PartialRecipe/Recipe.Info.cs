using System;

public partial class Recipe
{
    public string Name { get; }
    public int Servings { get; }
    public string[] Ingredient;
    public int IngredientNum;

    public Recipe(string name, int servings, int ingredientNum)
    {
        Name = name;
        Servings = servings;
        Ingredient = new string[ingredientNum];
    }
}