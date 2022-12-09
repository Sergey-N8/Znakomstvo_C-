/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int GetNamber(string massege)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(massege);

        if(int.TryParse(Console.ReadLine(), out result) && result > 9999 && result < 100000)
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

string GetPalindrom(int namber)
{
    int namber45 = namber - namber / 100 * 100;

    if(namber / 1000 == namber45 % 10 * 10 + namber45 / 10)
        return $"Да, {namber} полиндром";
    else
        return $"Нет, {namber} не полиндром";
}

int namber = GetNamber("Введите число ");

Console.WriteLine(GetPalindrom(namber));