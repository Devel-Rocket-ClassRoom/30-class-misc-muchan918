using System;
using System.Text;

Person person = new Person();
person.Name = "홍길동";
person.Age = 25;
person.Print();

Hello hello = new Hello();
hello.Hi();
hello.Bye();

int sum = Calculator.Add(10, 20);
int diff = Calculator.Subtract(30, 10);
int product = Calculator.Multiply(5, 6);

Console.WriteLine($"덧셈: {sum}");
Console.WriteLine($"뺄셈: {diff}");
Console.WriteLine($"곱셈: {product}");

string text = "  hello world  ";
Console.WriteLine(StringHelper.CleanAndUpper(text));
Console.WriteLine(StringHelper.Reverse("Hello"));
Console.WriteLine(StringHelper.IsNullOrEmpty(""));

double sqrt = Math.Sqrt(16);        // 4
double pow = Math.Pow(2, 3);        // 8
int max = Math.Max(10, 20);         // 20
int min = Math.Min(10, 20);         // 10

Console.WriteLine($"제곱근: {sqrt}");
Console.WriteLine($"거듭제곱: {pow}");
Console.WriteLine($"최댓값: {max}");
Console.WriteLine($"최솟값: {min}");

// 메서드 체이닝 없이
StringBuilder sb1 = new StringBuilder();
sb1.Append("Hello");
sb1.Append(" ");
sb1.Append("World");
string result1 = sb1.ToString();

// 메서드 체이닝 사용
string result2 = new StringBuilder()
    .Append("Hello")
    .Append(" ")
    .Append("World")
    .ToString();

Console.WriteLine(result1);
Console.WriteLine(result2);

string message = new MessageBuilder()
    .AddText("안녕하세요!")
    .AddNewLine()
    .AddText("반갑습니다.")
    .AddSpace()
    .AddText("좋은 하루 되세요.")
    .Build();

// 메서드 체이닝으로 좌표 이동
Point point = new Point(0, 0)
    .MoveBy(10, 10)
    .MoveBy(20, 20)
    .MoveBy(30, 30);

Console.WriteLine(point);

string text1 = "   Hello World   ";
string result = text1
    .Trim()
    .ToLower()
    .Replace(" ", " ");
Console.WriteLine(result);

MutableCircle circle = new MutableCircle(10);
Console.WriteLine($"반지름: {circle.Radius}");

circle.Radius = 20;  // 직접 변경 가능
Console.WriteLine($"반지름: {circle.Radius}");

ImmutableCircle circle1 = new ImmutableCircle(10);
Console.WriteLine($"원본 반지름: {circle1.Radius}");

// circle1.Radius = 20;  // 오류! 읽기 전용

ImmutableCircle circle2 = circle1.WithRadius(20);  // 새 객체 생성
Console.WriteLine($"새 원 반지름: {circle2.Radius}");
Console.WriteLine($"원본 반지름: {circle1.Radius}");

Player player1 = new Player("용사", 1);
Player player2 = player1.LevelUp();

Console.WriteLine($"player1: {player1.Name}, 레벨 {player1.Level}");
Console.WriteLine($"player2: {player2.Name}, 레벨 {player2.Level}");

string original = "Hello";
string modified = original.ToUpper();

Console.WriteLine($"원본: {original}");      // Hello (변경 안 됨)
Console.WriteLine($"수정본: {modified}");

Character hero = new Character("용사");
Console.WriteLine($"{hero.Name} - 레벨: {hero.Level}, 체력: {hero.Health}");

hero.TakeDamage(30);
hero.Heal(10);

int damage = GameHelper.CalculateDamage(10, 5);
bool alive = GameHelper.IsAlive(50);
string status = GameHelper.GetHealthStatus(30, 100);

Console.WriteLine($"계산된 데미지: {damage}");
Console.WriteLine($"생존 여부: {alive}");
Console.WriteLine($"체력 상태: {status}");

Vector2D result3 = new Vector2D(1, 1)
    .Add(2, 3)       // (3, 4)
    .Multiply(2)     // (6, 8)
    .Add(-1, -2);    // (5, 6)
Console.WriteLine($"결과 벡터: {result3}");