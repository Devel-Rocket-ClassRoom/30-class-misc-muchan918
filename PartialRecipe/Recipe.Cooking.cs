using System;

public partial class Recipe
{
    public void AddIngredient(string ingredient)
    {
        if (IngredientNum < Ingredient.Length)
        {
            Ingredient[IngredientNum] = ingredient;
            IngredientNum++;
        }
        else
        {
            Console.WriteLine("재료 가득참");
        }
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"=== {Name} ({Servings}인분) ===");
        Console.WriteLine("재료:");
        for (int i = 0; i < Ingredient.Length; i++)
        {
            Console.WriteLine($"  {i+1}. {Ingredient[i]}");
        }
    }

    public bool HasIngredient(string ingredient )
    {
        for (int i = 0; i < Ingredient.Length; i++)
        {
            if (Ingredient[i] == ingredient) return true;
        }
        return false;
    }
}