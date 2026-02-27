using System;

Console.WriteLine("=== 초기 화폐 ===");
Money money = new Money(100, 50);
Console.WriteLine($"지갑: {money.Gold}골드 {money.Silver}실버");
Console.WriteLine();

Console.WriteLine("=== 화폐 추가 ===");
Money money1 = money.Add(50, 30);
Console.WriteLine($"추가 후: {money1.Gold}골드 {money1.Silver}실버");
Console.WriteLine($"원본 지갑: {money.Gold}골드 {money.Silver}실버");
Console.WriteLine();

Console.WriteLine("=== 화폐 차감 ===");
Money money2 = money.Subtract(20, 30);
Console.WriteLine($"차감 후: {money2.Gold}골드 {money2.Silver}실버");
Console.WriteLine($"원본 지갑: {money.Gold}골드 {money.Silver}실버");
Console.WriteLine();

Console.WriteLine("=== 메서드 체이닝 ===");
Money money3 = money
    .Add(20, 10)
    .Add(10, 20)
    .Subtract(10, 50);
Console.WriteLine($"결과: {money3.Gold}골드 {money3.Silver}실버");