
/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }
    return result;
}

void GetNatNamber(int number)
{
    if (number < 1)
    {
        Console.Write($"{number}, ");
        GetNatNamber(number + 1);

    }
    else if (number > 1)
    {
        Console.Write($"{number}, ");
        GetNatNamber(number - 1);
    }
    else
    {
        Console.Write($"{number}.");
    }
}

int number = GetNumber($"Введите натуральное число");

GetNatNamber(number);
