using System;

Console.WriteLine("=== 기본 쿼리 ===");
string q1 = new QueryBuilder()
    .Select("*")
    .From("Users")
    .Build();
Console.WriteLine(q1);
Console.WriteLine();

Console.WriteLine("=== 조건 쿼리 ===");
string q2 = new QueryBuilder()
    .Select("Name, Age")
    .From("Users")
    .Where("Age > 18")
    .Build();
Console.WriteLine(q2);
Console.WriteLine();

Console.WriteLine("=== 정렬 쿼리 ===");
string q3 = new QueryBuilder()
    .Select("*")
    .From("Products")
    .Where("Price > 1000")
    .OrderBy("Price")
    .Build();
Console.WriteLine(q3);