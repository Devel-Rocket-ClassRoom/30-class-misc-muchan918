using System;

Recipe food1 = new Recipe("비빔밥", 2, 5);
food1.AddIngredient("밥");
food1.AddIngredient("고추장");
food1.AddIngredient("계란");
food1.AddIngredient("시금치");
food1.AddIngredient("당근");
food1.PrintRecipe();
Console.WriteLine();

Console.WriteLine($"계란 포함: {food1.HasIngredient("계란")}");
Console.WriteLine($"소고기 포함: {food1.HasIngredient("소고기")}");
Console.WriteLine();

Recipe food2 = new Recipe("샌드위치", 1, 3);
food2.AddIngredient("빵");
food2.AddIngredient("햄");
food2.AddIngredient("치즈");
food2.PrintRecipe();

