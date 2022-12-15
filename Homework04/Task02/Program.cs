/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int GetNamber(string massege)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(massege);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine($"Введите корректное число");
        }

    }

    return result;
}

void GetSumDigit(int namber)
{
    int digit = 0;
    int namberFoResult = namber;
    while(namber != 0)
    {
        digit = digit + namber % 10;
        namber = namber / 10;
    }
    Console.WriteLine($"Сумма цыфр числа {namberFoResult} ровна {digit}");
}

int namber = GetNamber("Введите число");

GetSumDigit(namber);