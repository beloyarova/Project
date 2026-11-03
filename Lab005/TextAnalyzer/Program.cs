using System.Collections;

string menu;
string vowels1 = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
string consonant1 = "БВГДЖЗЙКЛМНПРСТФХЦЧШЩбвгджзйклмнпрстфхцчшщъьЪЬ";
do
{
    Console.WriteLine("1 - Проанализировать предложение");
    Console.WriteLine("2 - Найти позицию первой заглавной буквы");
    Console.WriteLine("0 - Выход");
    Console.Write("Выберите пункт: ");
    menu = Console.ReadLine();

switch (menu)
{
    case "1":
            {
                Console.Write("Введите предложение: ");
                string sentence = Console.ReadLine();
                int vowel = 0;
                int consonant = 0;
                int space = 0;

                foreach (char letter in sentence)
                {
                    if (letter == ' ')
                    {
                        space++;
                        continue;
                    }

                    if (vowels1.Contains(letter))
                    {
                        vowel++;
                    }
                    
                    if (consonant1.Contains(letter))
                    {
                        consonant++;
                    }
                }

                Console.WriteLine($"Всего символов: {sentence.Length}");
                Console.WriteLine($"Гласных: {vowel}");
                Console.WriteLine($"Согласных: {consonant}");
                Console.WriteLine($"Пробелов: {space}");
                break;
            }

    case "2":
            {
                Console.Write("Введите предложение: ");
                string Sentence = Console.ReadLine();
                string upper = "ЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
                bool found = false;
                for (int i = 0; i < Sentence.Length; i++)
                {
                    char SENTENCE = Sentence[i];
                    if (upper.Contains(SENTENCE))
                    {
                        Console.WriteLine($"Первая заглавная буква находится на  позиции: {i+1}");
                        found = true;
                        break;
                    }

                }
                if (!found)
                {
                    Console.WriteLine("Заглавных букв нет");
                }
                break;
            }

    case "0":
            {
                Console.WriteLine("До свидания!");
                break;
            }
    }
} while (menu != "0") ;
