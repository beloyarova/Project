// // Шаг 2
// using System.Diagnostics.Tracing;
// using System.Runtime.InteropServices.Marshalling;

// void DoubleValue(ref int number)
// {
//     number = number * 2;
// }
// int x = 5;
// DoubleValue(ref x);
// Console.WriteLine($"x = {x}");

// void Swap(ref int a, ref int b)
// {
//     int temp = a;
//     a = b;
//     b = temp;
// }
// int c = 1;
// int d = 2;
// Swap(ref c, ref d);
// Console.WriteLine($"c = {c}, d = {d}");

// // Шаг 3
// bool TryDivide(int a, int b, out int result)
// {
//     if (b == 0)
//     {
//         result = 0;
//         return false;
//     }
//     result = a / b;
//     return true;
// }

// Console.WriteLine(TryDivide(10, 5, out int result));
// Console.WriteLine(TryDivide(10, 0, out int result1));

// void FOO(int a, int b, out int a1, out int a2)
// {
//     a1 = a / b;
//     a2 = a % b;
// }
// FOO(21, 5, out int b1, out int b2);
// Console.WriteLine($"{b1}, {b2}");

// // Шаг 4

// CharacterStats stats1 = new CharacterStats();
// stats1.Health = 100;
// stats1.Damage = 50;
// stats1.Armor = 20;
// PrintStats(in stats1);

// void PrintStats(in CharacterStats stats)
// {
//     Console.WriteLine($"HP: {stats.Health}");
//     Console.WriteLine($"Урон: {stats.Damage}");
//     Console.WriteLine($"Броня: {stats.Armor}");
// }

// struct CharacterStats
// {
//     public int Health;
//     public int Damage;
//     public int Armor;
// }

// Шаг 5
Console.WriteLine(Hero("Настя", 1));
Console.WriteLine(Hero("Аделина", 5, attributes: "сила 3"));
Console.WriteLine(Hero(attributes: "ловкость 10", level: 3, Class: "Призрак", name: "Лена"));


string Hero(string name, int level, string Class = "Новичок", string attributes = "")
{
    string a = "";
    if (attributes != "")
    {
        a = $"{name}, ур.{level}, класс: {Class}, характеристики: {attributes}";
    }
    else
    {
        a = $"{name}, ур.{level}, класс: {Class}";
    }
    return a;
}