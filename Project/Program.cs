// Банкомат

using System.Collections;
using System.Collections.Concurrent;

string correctPassword = "1234";
int balance = 10000;

int falledPin = 0;
bool correctPin = false;

while (falledPin < 3 && !correctPin)
{
    Console.Write("Введите PIN: ");
    string pin = Console.ReadLine();
    if (pin == correctPassword)
    {
        correctPin = true;
    }
    else
    {
        falledPin++;
        int popitka = 3 - falledPin;
        if (popitka > 0)
        {
            Console.WriteLine($"Неверный PIN. Осталось попыток: {popitka}");
        }
        else
        {
            Console.WriteLine("Неверный PIN");
        }
    }
}
if (!correctPin)
{
    Console.WriteLine("Карта заблокирована. Обратитесь в банк");
}
else
{
    bool exit = true;
    while (exit)
    {
        Console.WriteLine();
        Console.WriteLine("1. Баланс");
        Console.WriteLine("2. Пополнить");
        Console.WriteLine("3. Снять");
        Console.WriteLine("0. Выход");
        Console.Write("Выберите пункт: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine();
                Console.WriteLine($"Баланс: {balance}");
                break;
            case 2:
                Console.WriteLine();
                Console.Write("Введите сумму пополнения: ");
                int summa = int.Parse(Console.ReadLine());
                balance = balance + summa;
                Console.WriteLine("Пополнение выполнено. Хорошего дня!");
                break;
            case 3:
                Console.WriteLine();
                Console.Write("Введите сумму снятия: ");
                int snatie = int.Parse(Console.ReadLine());
                if (snatie > balance)
                {
                    Console.WriteLine("Недостаточно средств");
                }
                else
                {
                    balance = balance - snatie;
                    Console.WriteLine("Снятие выполнено. Хорошего дня!");
                }
                break;
            case 0:
                Console.WriteLine();
                Console.WriteLine("Хорошего дня!");
                exit = false;
                break;
            default:
                Console.WriteLine();
                Console.WriteLine("Такого пункта нет");
                break;
        }
    }
    Console.WriteLine("До свидания!");
}