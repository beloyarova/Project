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

// // Шаг 5
// Console.WriteLine(Hero("Настя", 1));
// Console.WriteLine(Hero("Аделина", 5, attributes: "сила 3"));
// Console.WriteLine(Hero(attributes: "ловкость 10", level: 3, Class: "Призрак", name: "Лена"));


// string Hero(string name, int level, string Class = "Новичок", string attributes = "")
// {
//     string a = "";
//     if (attributes != "")
//     {
//         a = $"{name}, ур.{level}, класс: {Class}, характеристики: {attributes}";
//     }
//     else
//     {
//         a = $"{name}, ур.{level}, класс: {Class}";
//     }
//     return a;
// }

// Итоговая задача

// 1
using System.Threading.Channels;

void Eat(ref int hungerLevel, int food)
{
    hungerLevel = hungerLevel + food;
    if (hungerLevel > 100)
    {
        hungerLevel = 100;
    }
}

// 2
int Work(int hours, int stavka, int bonus)
{
    return (hours * stavka + bonus);
}

// 3
bool Cook(int skill, int difficulty, out int yspex)
{
    if (skill < difficulty)
    {
        yspex = 0;
        return false;
    }
    yspex = (skill - difficulty + 1) * 20;
    return true;
}

// 4
void PrintSkills(in SimSkills skills)
{
    Console.WriteLine($"Готовка: {skills.Cooking}, Фитнес: {skills.Fitness}, Логика: {skills.Logic}");
}

// 5
void Sim(string name, int level, bool full = false)
{
    if (full)
    {
        Console.WriteLine($"Сим: {name}, уровень карьеры: {level}");
    }
    else
    {
        Console.WriteLine($"Сим: {name}");
    }
}

SimSkills sim1 = new SimSkills();
sim1.Cooking = 5;
sim1.Fitness = 1;
sim1.Logic = 10;

SimSkills sim2 = new SimSkills();
sim2.Cooking = 10;
sim2.Fitness = 7;
sim2.Logic = 5;

int hunger = 40;
Console.WriteLine($"Сытость до еды: {hunger}");
Eat(ref hunger, 55);
Console.WriteLine($"Сытость после еды: {hunger}");

int money = Work(9, 175, 400);
Console.WriteLine($"Заработок за смену: {money} симолеонов");

bool Good = Cook(sim1.Cooking, 4, out int quality);
if (Good)
{
    Console.WriteLine($"Блюдо приготовлено качество: {quality}");
}
else
{
    Console.WriteLine("Навык готовки слишком низкий");
}

Good = Cook(sim2.Cooking, 15, out quality);
if (Good)
{
    Console.WriteLine($"Блюдо приготовлено, качество: {quality}");
}
else
{
    Console.WriteLine($"Навык готовки слишком низкий, качество: {quality}");
}

Console.WriteLine($"Уровень скилов персонажа 1: ");
PrintSkills(sim1);

Sim("Аделина", 10);
Sim("Настя", 20, full: true);

struct SimSkills
{
    public int Cooking;
    public int Fitness;
    public int Logic;
}
